using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReelManagement.Buttons;
using ReelManagement.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ReelManagement
{
    public partial class mainmenu : Form
    {
        private RoundButton CurrentBtn;
        private Form currentChildForm;
        private string loggedInUsername;
        private string userRole;
        private string loggedInPassword;
        public mainmenu(string username, string role, string password)
        {
            InitializeComponent();
            datetime_timer.Start();
            loggedInUsername = username;
            userRole = role;
            loggedInPassword = password;
            UpdateUserInfo();
        }

        //updating user info
        private void UpdateUserInfo()
        {
            username_lbl.Text = loggedInUsername;
            role_lbl.Text = userRole;
        }
        int size = 0;//flag for window size(even if small, odd if large)
        private void mainmenu_SizeChanged(object sender, EventArgs e)
        {
            size += 1;
            if (size % 2 == 0)
            {
                username_lbl.Location = new Point(45, 152);
                role_lbl.Location = new Point(45, 180);
                Bosch_Logo.Size = new Size(200, 133);
            }
            else
            {
                username_lbl.Location = new Point(160, 300);
                role_lbl.Location = new Point(160, 335);
                Bosch_Logo.Size = new Size(400, 266);
            }
        }

        //date and time
        private void datetime_timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeAndDate();
        }
        private void UpdateTimeAndDate()
        {
            timelbl.Text = DateTime.Now.ToString("g");
        }

        ///NavBar*****************************************************************************
        //NavBar Buttons
        private void ActivateButton(object sender)
        {
            DisableButton();
            if (sender != null)
            {
                CurrentBtn = (RoundButton)sender;
                CurrentBtn.BackColor = Color.Gray;
                CurrentBtn.ForeColor = Color.WhiteSmoke;
            }
        }
        private void DisableButton()
        {
            if (CurrentBtn != null)
            {
                CurrentBtn.BackColor = Color.WhiteSmoke;
                CurrentBtn.ForeColor = Color.Black;
            }
        }
        //opening child forms
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
            ChildFrom.Size = this.ClientSize;
            Controls.Add(ChildFrom);
            ChildFrom.Show();
        }
        private void IN_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildFrom(new input_reel(loggedInUsername));
            top_label.Text = "Input Transaction";
        }
        private void OUT_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildFrom(new output_reel(loggedInUsername));
            top_label.Text = "Output Transaction";
        }
        private void inventory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildFrom(new Inventory());
            top_label.Text = "Inventory";
        }
        private void report_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildFrom(new report());
            top_label.Text = "Report";
        }
        private void admin_button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildFrom(new admin1(userRole, loggedInUsername));
            top_label.Text = "Authorisation";
        }


        //logout
        private void ClearUserData()
        {
            username_lbl.Text = "";
            role_lbl.Text = "";
        }
        private void ShowLoginForm()
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }
        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        {
            ClearUserData();
            ShowLoginForm();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            ClearUserData();
            ShowLoginForm();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearUserData();
            ShowLoginForm();
        }

        //Default page is INPUT REEL 
        private void mainmenu_Load(object sender, EventArgs e)
        {
            OpenChildFrom(new input_reel(loggedInUsername));
            top_label.Text = "Input Transaction";
        }


        
    }
}
