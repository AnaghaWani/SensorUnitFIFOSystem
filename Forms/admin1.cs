using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReelManagement.Forms
{
    public partial class admin1 : Form
    {
        bool sidebarExpand;
        private Form currentChildForm;
        string UserRole;
        string CurrUser;
        public admin1(string role, string curruser)
        {
            InitializeComponent();
            this.UserRole = role;
            this.CurrUser = curruser;
        }
        //Childforms
        private void OpenChildFrom(Form ChildFrom)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildFrom;
            ChildFrom.TopLevel = false;
            ChildFrom.FormBorderStyle = FormBorderStyle.None;
            ChildFrom.Dock = DockStyle.Fill;
            Controls.Add(ChildFrom);
            ChildFrom.Show();
        }

        //Navigation bar
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        //Managing access for variou rolesd
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (UserRole == "Admin" || UserRole == "FLM")
            {
                OpenChildFrom(new create_account());
            }
            else
            {
                MessageBox.Show("You do not have authority to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (UserRole == "Admin" || UserRole == "FLM")
            {
                OpenChildFrom(new edit_users());
            }
            else
            {
                MessageBox.Show("You do not have authority to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (UserRole == "Admin")
            {
                OpenChildFrom(new manage_data(CurrUser));
            }
            else
            {
                MessageBox.Show("You do not have authority to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
