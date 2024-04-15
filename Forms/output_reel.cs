using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZXing;
using System.IO.Ports;

namespace ReelManagement
{
    public partial class output_reel : Form
    {
        private string CurrentUser;
        string exp_loc;
        SqlConnection connect = new SqlConnection(@"Data Source=CHKVSQL03.APAC.BOSCH.COM;Initial Catalog=DB_MOE1DeviceBridgeTrial_SQL;User ID=DeviceBridge_MOE1_Grob8;Password=DeviceBridge_MOE1_Grob8;Persist Security Info=True");
        public output_reel(string username)
        {
            InitializeComponent();
            CurrentUser = username;
            UpdatePanelColors();
            prompt.Visible = false;
        }
        //RFID Scan
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
        //rescan functionality
        private void rescan()
        {
            reel_type_no.Text = "";
            reel_quantity.Text = "";
            reel_batch_no.Text = "";
            rack_loc.Text = "";
            prompt.Visible = false;
        }
        private void refresh()
        {
            exp_typeno.Text = "";
            typenr.Text = "";
            exp_quantity.Text = "";
            exp_batchno.Text = "";
            exp_rack_loc.Text = "";
        }
        private void roundButton1_Click(object sender, EventArgs e)
        {
            rescan();
        }

        //get the shift in which transaction was done
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

        //Saving scanned information into the database
        private void save_Click(object sender, EventArgs e)
        {
            comparison_result();
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
            if (!int.TryParse(reel_quantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            quantity = Convert.ToInt32(reel_quantity.Text);

            DialogResult result = MessageBox.Show("Do you want to confirm the details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    // Insert data into the database
                    string insertQuery = "INSERT INTO TransactionRecords (txn_date, txn_time, txn_shift, type_no, quantity, batch_no, curr_user, txn_type, rack_loc,exp_rack_loc) " +
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
                    command.Parameters.AddWithValue("@txnType", "OUT");
                    command.Parameters.AddWithValue("@exp_rack_loc", exp_loc);

                    command.ExecuteNonQuery();
                    //rack location update(v:vacant, o:occupied)
                    string updateQuery = "UPDATE racklocations SET loc_status = 'v' WHERE rack_loc = @rack_loc";
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
                refresh();
            }
        }

        //Updating colors for the rack
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

        //Displaying the expected reel prompt
        private void GetFifoRackLoc(string typeNumber)
        {
            try
            {
                connect.Open();

                // Retrieve the first available rack location for the specified type number based on FIFO logic
                string query = @"SELECT TOP 1 rack_loc, batch_no, quantity
                         FROM TransactionRecords 
                         WHERE type_no = @typeNumber 
                         AND rack_loc IN (SELECT rack_loc FROM racklocations WHERE loc_status = 'o')
                         ORDER BY txn_date, txn_time";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@typeNumber", typeNumber);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string suggestedRackLocation = reader.GetString(0);
                    exp_loc = suggestedRackLocation;
                    string batchNo = reader.GetString(1);
                    Int64 quantity = reader.GetInt64(2);

                    // Display the retrieved values in the respective text boxes
                    exp_rack_loc.Text = suggestedRackLocation;
                    exp_batchno.Text = batchNo;
                    exp_quantity.Text = quantity.ToString();
                }
                else
                {
                    // Clear the text boxes if no records are found
                    MessageBox.Show("No reel found for selected part number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    exp_rack_loc.Text = "";
                    exp_batchno.Text = "";
                    exp_quantity.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error suggesting rack location: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
        private void typenr_TextChanged(object sender, EventArgs e)
        {
            exp_typeno.Text = typenr.Text;
            GetFifoRackLoc(typenr.Text);
        }
        private void typenr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //comparing the expected and the scanned reel data and prompting for its veracity
        public bool compare_data()
        {
            string expectedQuantity = exp_quantity.Text.Trim();
            string expectedTypeNo = exp_typeno.Text.Trim();
            string expectedBatchNo = exp_batchno.Text.Trim();
            string expectedRackLocation = exp_rack_loc.Text.Trim();
            string actualQuantity = reel_quantity.Text.Trim();
            string actualTypeNo = reel_type_no.Text.Trim();
            string actualBatchNo = reel_batch_no.Text.Trim();
            string actualRackLocation = rack_loc.Text.Trim();

            bool quantityMatch = string.Equals(expectedQuantity, actualQuantity, StringComparison.OrdinalIgnoreCase);
            bool typeNoMatch = string.Equals(expectedTypeNo, actualTypeNo, StringComparison.OrdinalIgnoreCase);
            bool batchNoMatch = string.Equals(expectedBatchNo, actualBatchNo, StringComparison.OrdinalIgnoreCase);
            bool rackLocationMatch = string.Equals(expectedRackLocation, actualRackLocation, StringComparison.OrdinalIgnoreCase);

            // Return true if all fields match, otherwise false
            return quantityMatch && typeNoMatch && batchNoMatch && rackLocationMatch;
        }
        private void comparison_result()
        {
            bool comp_result = compare_data();
            if (comp_result == true)
            {
                prompt.Visible = true;
                string imagePath = "C:\\Users\\waa3chk\\Desktop\\ReelManagement\\ReelManagement\\ReelManagement\\assets\\icons8-tiktok-verified-account-64.png";
                wrong.Image = Image.FromFile(imagePath);
                match_messege.Text = "The scanned reel is \n same as expected";
                match_messege.BackColor = Color.FromArgb(33, 228, 166);
            }
            else
            {
                prompt.Visible = true;
                string imagePath2 = "C:\\Users\\waa3chk\\Desktop\\ReelManagement\\ReelManagement\\ReelManagement\\assets\\icons8-cross-100.png";
                wrong.Image = Image.FromFile(imagePath2);
                match_messege.Text = "The scanned reel is \n not same as expected";
                match_messege.BackColor = Color.FromArgb(230, 41, 70);
            }
        }

    }
}
