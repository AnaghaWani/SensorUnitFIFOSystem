using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.IO.Ports;


namespace ReelManagement
{
    public partial class input_reel : Form
    {
        private string CurrentUser;
        string exp_loc;
        SqlConnection connect = new SqlConnection(@"Data Source=CHKVSQL03.APAC.BOSCH.COM;Initial Catalog=DB_MOE1DeviceBridgeTrial_SQL;User ID=DeviceBridge_MOE1_Grob8;Password=DeviceBridge_MOE1_Grob8;Persist Security Info=True");
        public input_reel(string username)
        {
            InitializeComponent();
            CurrentUser = username;
            UpdatePanelColors();
            FifoRackLoc();//insert it after scan function later
        }
        //RFID Scanner
        private string ReadFromRFIDScanner()
        {
            try
            {
                string portName = "COM3"; // Replace with your RFID scanner's COM port
                int baudRate = 9600; // Replace with your RFID scanner's baud rate

                using (SerialPort port = new SerialPort(portName, baudRate))
                {
                    port.Open();

                    // Read data from the serial port (assuming the RFID scanner sends data as a single line)
                    string scannedData = port.ReadLine();

                    port.Close();

                    return scannedData.Trim(); // Trim any whitespace characters
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from RFID scanner: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void ProcessScannedQRCode(string scannedData)
        {
            // Split the scanned data to extract type_no, quantity, and batch number
            string[] parts = scannedData.Split('#');

            if (parts.Length < 5)
            {
                MessageBox.Show("Invalid QR code format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string typeNo = parts[1];
            int quantity;
            if (!int.TryParse(parts[3], out quantity))
            {
                MessageBox.Show("Invalid quantity in QR code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string batchNumber = parts[4];

            // Fill the form fields with extracted data
            reel_type_no.Text = typeNo;
            reel_quantity.Text = quantity.ToString();
            reel_batch_no.Text = batchNumber;
        }
        private void Scan_Click(object sender, EventArgs e)
        {
            string scannedData = ReadFromRFIDScanner();

            if (!string.IsNullOrEmpty(scannedData))
            {
                ProcessScannedQRCode(scannedData);
            }
            else
            {
                MessageBox.Show("Error scanning: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Rescan
        private void rescan()
        {
            reel_type_no.Text = "";
            reel_quantity.Text = "";
            reel_batch_no.Text = "";
            rack_loc.Text = "";
        }
        //determine the shift
        private string GetShift(TimeSpan currentTime)
        {
            if (currentTime >= TimeSpan.Parse("07:00") && currentTime < TimeSpan.Parse("15:30"))
            {
                return "1st";
            }
            else if (currentTime >= TimeSpan.Parse("15:30") && currentTime < TimeSpan.Parse("23:59"))
            {
                return "2nd";
            }
            else
            {
                return "3rd";
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            // Retrieve data from text boxes
            string typeNumber = reel_type_no.Text.Trim();
            int quantity;
            string batchNumber = reel_batch_no.Text.Trim();
            string rackLocation = rack_loc.Text.Trim();
            string shift = GetShift(DateTime.Now.TimeOfDay);

            if (string.IsNullOrEmpty(typeNumber) || string.IsNullOrEmpty(batchNumber) || string.IsNullOrEmpty(rackLocation) || string.IsNullOrEmpty(reel_quantity.Text))
            {
                MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if reel_quantity is a valid integer
            if (!int.TryParse(reel_quantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            quantity = Convert.ToInt32(reel_quantity.Text);

            // Check if the batch number already exists in the database
            if (BatchNumberExists(batchNumber))
            {
                MessageBox.Show("Batch number already exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to save the details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    // Insert data into the database
                    string insertQuery = "INSERT INTO TransactionRecords (txn_date, txn_time, txn_shift, type_no, quantity, batch_no, curr_user, txn_type, rack_loc, exp_rack_loc) " +
                                         "VALUES (@date, @time, @shift, @typeNo, @quantity, @batchNo, @currentUser, @txnType, @rack_loc, @exp_rack_loc)";
                    SqlCommand command = new SqlCommand(insertQuery, connect);

                    command.Parameters.AddWithValue("@date", DateTime.Today);
                    command.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm"));
                    command.Parameters.AddWithValue("@shift", shift);
                    command.Parameters.AddWithValue("@typeNo", typeNumber);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@batchNo", batchNumber);
                    command.Parameters.AddWithValue("@rack_loc", rackLocation);
                    command.Parameters.AddWithValue("@currentUser", CurrentUser);
                    command.Parameters.AddWithValue("@txnType", "IN");
                    command.Parameters.AddWithValue("@exp_rack_loc", exp_loc);

                    command.ExecuteNonQuery();

                    // Rack location update (vacant -> occupied)
                    string updateQuery = "UPDATE racklocations SET loc_status = 'o' WHERE rack_loc = @rack_loc";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connect);
                    updateCommand.Parameters.AddWithValue("@rack_loc", rackLocation);
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
                rescan();
                UpdatePanelColors();
                FifoRackLoc();
            }
        }
        //checks if the batchnumber is already scanned
        private bool BatchNumberExists(string batchNumber)
        {
            try
            {
                // Extract the date part from the batch number
                string dateString = batchNumber.Substring(5, 10); // Extracts '2024-02-22' from 'B#L30842024-02-22B-2'
                DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                connect.Open();

                string formattedDate = date.ToString("yyyy-MM-dd");

                string query = "SELECT COUNT(*) FROM TransactionRecords WHERE txn_date = @txnDate AND batch_no = @batchNo";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@txnDate", formattedDate);
                command.Parameters.AddWithValue("@batchNo", batchNumber);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking batch number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Assume batch number exists to prevent unintended actions
            }
            finally
            {
                connect.Close();
            }
        }
        private void roundButton1_Click(object sender, EventArgs e)
        {
            rescan();
        }
        //Updating the panl colors
        private void UpdatePanelColors()
        {
            try
            {
                connect.Open();
                string query = "SELECT rack_loc, loc_status FROM racklocations";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();

                // Iterate over the reader to update panel colors
                while (reader.Read())
                {
                    string rackNumber = reader.GetString(0);
                    string status = reader.GetString(1);

                    // Find the panel corresponding to the rack location
                    Panel panel = this.Controls.Find(rackNumber, true).FirstOrDefault() as Panel;

                    if (panel != null)
                    {
                        if (status == "o")
                        {
                            panel.BackColor = Color.FromArgb(230, 41, 70);
                        }
                        else if (status == "v")
                        {
                            panel.BackColor = Color.FromArgb(33, 228, 166);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating panel colors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
        private void FifoRackLoc()
        {
            try
            {
                connect.Open();
                string query = "SELECT TOP 1 rack_loc FROM racklocations WHERE loc_status = 'v' ORDER BY rack_loc";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string suggestedRackLocation = reader.GetString(0);
                    rack_loc.Text = suggestedRackLocation;
                    exp_loc = suggestedRackLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Suggesting Rack Location: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
