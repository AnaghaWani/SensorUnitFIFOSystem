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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ReelManagement.Forms
{
    public partial class edit_users : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=CHKVSQL03.APAC.BOSCH.COM;Initial Catalog=DB_MOE1DeviceBridgeTrial_SQL;User ID=DeviceBridge_MOE1_Grob8;Password=DeviceBridge_MOE1_Grob8;Persist Security Info=True");
        public edit_users()
        {
            InitializeComponent();
            LoadData();
        }
        //Loading data into the datagrid Table
        private void LoadData()
        {
            try
            {
                connect.Open();

                string query = "SELECT username AS UserName, user_role AS Role, date_created AS Date, passwrd AS Password FROM emp_accounts";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                user_info.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        //selects the row
        private void user_info_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (user_info.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = user_info.SelectedRows[0];
                string username = selectedRow.Cells["UserName"].Value.ToString();
                string role = selectedRow.Cells["Role"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                user_name.Text = username;
                pwd.Text = password;
                usr_role.Text = role;
            }

        }

        //Edit functionality
        private void edit_ac_Click(object sender, EventArgs e)
        {
            if (user_info.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = user_info.SelectedRows[0];
                    string old_username = selectedRow.Cells["username"].Value.ToString();
                    DateTime date = DateTime.Today;
                    try
                    {
                        connect.Open();
                        string updateQuery = "UPDATE emp_accounts SET username = @username, user_role = @role, passwrd=@password, date_updated = @date_updated WHERE username=@old_username";
                        SqlCommand command = new SqlCommand(updateQuery, connect);
                        command.Parameters.AddWithValue("@username", user_name.Text);
                        command.Parameters.AddWithValue("@role", usr_role.Text);
                        command.Parameters.AddWithValue("@password", pwd.Text);
                        command.Parameters.AddWithValue("@date_updated", date);
                        command.Parameters.AddWithValue("@old_username", old_username);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Row updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                            connect.Close();
                    }
                    refresh_data();
                }

            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //delete functionality
        private void delete_ac_Click(object sender, EventArgs e)
        {
            if (user_info.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = user_info.SelectedRows[0];
                    string username = selectedRow.Cells["username"].Value.ToString();

                    try
                    {
                        connect.Open();
                        string deleteQuery = "DELETE FROM emp_accounts WHERE username = @username";

                        SqlCommand command = new SqlCommand(deleteQuery, connect);
                        command.Parameters.AddWithValue("@username", username);
                        command.ExecuteNonQuery();
                        user_info.Rows.RemoveAt(selectedRow.Index);

                        MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting row from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                            connect.Close();
                    }
                    refresh_data();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //search functionality
        private void searchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_btn.PerformClick();
            }
        }
        private void roundButton3_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            string searchQuery = searchbox.Text.Trim();

            try
            {
                connect.Open();

                string query = "SELECT username AS UserName, user_role AS Role, date_created AS Date, passwrd AS Password FROM emp_accounts WHERE username LIKE @searchQuery";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                user_info.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing search query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }
        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void searchbox_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search")
            {
                searchbox.Text = "";
                searchbox.ForeColor = Color.Black;
            }
        }

        //data refresh 
        private void refresh_data()
        {
            user_name.Text = "";
            usr_role.Text = "";
            pwd.Text = "";
            LoadData();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            refresh_data();
            searchbox.Text = "Search";
            searchbox.ForeColor = Color.DimGray;
        }
        

       
    }
}
