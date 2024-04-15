using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReelManagement.Forms
{
    public partial class manage_data : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=CHKVSQL03.APAC.BOSCH.COM;Initial Catalog=DB_MOE1DeviceBridgeTrial_SQL;User ID=DeviceBridge_MOE1_Grob8;Password=DeviceBridge_MOE1_Grob8;Persist Security Info=True");
        string userName;
        public manage_data(string username)
        {
            InitializeComponent();
            this.userName = username;
        }
        //Edit the minimum and maximum quantity for each part
        private void SaveMinMax()
        {
            string typeNo = type_no.SelectedItem?.ToString();
            string minVal = min_val.Text.Trim();
            string maxVal = max_val.Text.Trim();

            // Check if any of the fields are empty
            if (string.IsNullOrEmpty(typeNo) || string.IsNullOrEmpty(minVal) || string.IsNullOrEmpty(maxVal))
            {
                MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int minValue;
            int maxValue;

            // Validate if minVal and maxVal are valid integers
            if (!int.TryParse(minVal, out minValue) || !int.TryParse(maxVal, out maxValue))
            {
                MessageBox.Show("Please enter valid min and max values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to save the details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    // Insert data into the database
                    string insertQuery = "UPDATE ReadingType SET MinValue = @minValue, MaxValue = @maxValue WHERE Type_No = @typeNo";
                    SqlCommand command = new SqlCommand(insertQuery, connect);

                    command.Parameters.AddWithValue("@typeNo", typeNo);
                    command.Parameters.AddWithValue("@minValue", minValue);
                    command.Parameters.AddWithValue("@maxValue", maxValue);

                    command.ExecuteNonQuery();

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
            }
        }
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            SaveMinMax();
        }

        //manual editing option for the transactions
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
        private void UpdateTransactionRecord(string batchNumber)
        {
            try
            {
                string dateString = batchNumber.Substring(5, 10);
                string shift = GetShift(DateTime.Now.TimeOfDay);
                DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                connect.Open();

                string formattedDate = date.ToString("yyyy-MM-dd");
                string currDate = DateTime.Now.ToString("yyyy-MM-dd");
                string currentTime = DateTime.Now.ToString("HH:mm");

                string fetchQuery = @"SELECT quantity, type_no, rack_loc FROM TransactionRecords WHERE batch_no = @batchNo";
                SqlCommand fetchCommand = new SqlCommand(fetchQuery, connect);
                fetchCommand.Parameters.AddWithValue("@batchNo", batchNumber);

                SqlDataReader reader = fetchCommand.ExecuteReader();

                int quantity = 0;
                string TypeNo = "";
                string rackLoc = "";
                string txnType = "OUT";

                if (reader.Read())
                {
                    quantity = Convert.ToInt32(reader["quantity"]);
                    TypeNo = reader["type_no"].ToString();
                    rackLoc = reader["rack_loc"].ToString();
                }

                reader.Close();

                string insertQuery = @"
            INSERT INTO TransactionRecords 
            (txn_date, txn_time, txn_shift, type_no, quantity, batch_no, curr_user, txn_type, rack_loc, exp_rack_loc)
            VALUES 
            (@txnDate, @txnTime,@shift, @typeNo, @quantity, @batchNo, @currUser, @txnType, @rackLoc, @expRackLocation)";

                SqlCommand insertCommand = new SqlCommand(insertQuery, connect);
                insertCommand.Parameters.AddWithValue("@txnDate", currDate);
                insertCommand.Parameters.AddWithValue("@txnTime", currentTime);
                insertCommand.Parameters.AddWithValue("@shift", shift);
                insertCommand.Parameters.AddWithValue("@typeNo", TypeNo);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);
                insertCommand.Parameters.AddWithValue("@batchNo", batchNumber);
                insertCommand.Parameters.AddWithValue("@currUser", userName);
                insertCommand.Parameters.AddWithValue("@txnType", txnType);
                insertCommand.Parameters.AddWithValue("@rackLoc", rackLoc);
                insertCommand.Parameters.AddWithValue("@expRackLocation", rackLoc);

                insertCommand.ExecuteNonQuery();

                // Rack location update (vacant -> occupied)
                string updateQuery = "";
                if (txnType == "IN")
                {
                    updateQuery = "UPDATE racklocations SET loc_status = 'o' WHERE rack_loc = @rack_loc";
                }
                else if (txnType == "OUT")
                {
                    updateQuery = "UPDATE racklocations SET loc_status = 'v' WHERE rack_loc = @rack_loc";
                }

                SqlCommand updateCommand = new SqlCommand(updateQuery, connect);
                updateCommand.Parameters.AddWithValue("@rack_loc", rackLoc);
                updateCommand.ExecuteNonQuery();

                MessageBox.Show("Transaction record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating transaction record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            string batch_no = b_no.Text.Trim();
            UpdateTransactionRecord(batch_no);
        }

    }
}
