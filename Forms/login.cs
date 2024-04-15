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

namespace ReelManagement
{
    public partial class login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=CHKVSQL03.APAC.BOSCH.COM;Initial Catalog=DB_MOE1DeviceBridgeTrial_SQL;User ID=DeviceBridge_MOE1_Grob8;Password=DeviceBridge_MOE1_Grob8;Persist Security Info=True");
        public login()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                username.ForeColor = Color.Black;
                label4.Visible = false;
            }
            catch { }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                password.ForeColor = Color.Black;
                label5.Visible = false;
            }
            catch { }
        }
        //Login Btn functionality
        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                label4.Visible = true;
                return;
            }
            if (password.Text == "")
            {
                label5.Visible = true;
                return;
            }
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string checkUserQuery = "SELECT username, user_role, passwrd FROM emp_accounts WHERE username = @username AND passwrd = @password";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, connect))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        checkUserCmd.Parameters.AddWithValue("@password", password.Text.Trim());

                        SqlDataReader reader = checkUserCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string loggedInUsername = reader["username"].ToString();
                            string userRole = reader["user_role"].ToString();
                            string user_password = reader["passwrd"].ToString();

                            MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Navigate to the mainmenu form and pass the username and role
                            mainmenu mainMenuForm = new mainmenu(loggedInUsername, userRole, user_password);
                            mainMenuForm.Show();
                            this.Hide(); // Hide the login form
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            }
        }
        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button.PerformClick();
            }
        }
    }
}
