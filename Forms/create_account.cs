using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReelManagement
{
    public partial class create_account : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=CHKVSQL03.APAC.BOSCH.COM;Initial Catalog=DB_MOE1DeviceBridgeTrial_SQL;User ID=DeviceBridge_MOE1_Grob8;Password=DeviceBridge_MOE1_Grob8;Persist Security Info=True");
        public create_account()
        {
            InitializeComponent();
        }

        private void role_Click(object sender, EventArgs e)
        {
            if (role.Text == "Select")
            {
                role.Text = "";
            }
            role.ForeColor = Color.Black;
        }

        //Update data to database
        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                // Check if all fields are filled with appropriate data
                if (string.IsNullOrWhiteSpace(username.Text) ||
                    string.IsNullOrWhiteSpace(role.Text) ||
                    string.IsNullOrWhiteSpace(password.Text) ||
                    password.Text == "Enter password" ||
                    username.Text == "Enter name" ||
                    role.Text == "Select")
                {
                    MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    connect.Open();

                    // Check if the username already exists
                    string checkUserQuery = "SELECT COUNT(*) FROM emp_accounts WHERE username = @username";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, connect))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        int userCount = (int)checkUserCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show(username.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user account
                    string insertData = "INSERT INTO emp_accounts (username, user_role, passwrd, date_created) VALUES (@username, @role, @password, @date)";
                    DateTime date = DateTime.Today;

                    using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                    {
                        insertCmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@role", role.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@password", password.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@date", date);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Account Creation Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting the database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
                refresh_data();
            }
        }

        //Clear entered data
        private void refresh_data()
        {
            role.ForeColor = Color.DimGray;
            username.Text = "";
            password.Text = "";
            role.Text = "Select";
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            refresh_data();
        }
    }
}
