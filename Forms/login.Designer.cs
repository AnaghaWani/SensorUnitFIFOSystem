namespace ReelManagement
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            login_button = new Buttons.RoundButton();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            password = new TextBox();
            username = new TextBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            IN = new Buttons.RoundButton();
            OUT = new Buttons.RoundButton();
            inventory = new Buttons.RoundButton();
            report = new Buttons.RoundButton();
            admin_button = new Buttons.RoundButton();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 179, 168);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1500, 60);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(login_button);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(480, 197);
            panel2.MaximumSize = new Size(689, 610);
            panel2.MinimumSize = new Size(669, 599);
            panel2.Name = "panel2";
            panel2.Size = new Size(669, 599);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bosch Office Sans", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(363, 368);
            label5.Name = "label5";
            label5.Size = new Size(112, 16);
            label5.TabIndex = 19;
            label5.Text = "invalid password";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bosch Office Sans", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(363, 262);
            label4.Name = "label4";
            label4.Size = new Size(115, 16);
            label4.TabIndex = 18;
            label4.Text = "invalid username";
            label4.Visible = false;
            // 
            // login_button
            // 
            login_button.BackColor = SystemColors.Control;
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 179, 168);
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.ForeColor = Color.Black;
            login_button.Location = new Point(205, 448);
            login_button.Name = "login_button";
            login_button.Size = new Size(235, 65);
            login_button.TabIndex = 12;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += roundButton1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(128, 318);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bosch Office Sans", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(284, 78);
            label3.Name = "label3";
            label3.Size = new Size(116, 44);
            label3.TabIndex = 16;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(241, 338);
            label2.Name = "label2";
            label2.Size = new Size(116, 27);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 230);
            label1.Name = "label1";
            label1.Size = new Size(121, 27);
            label1.TabIndex = 14;
            label1.Text = "Username";
            // 
            // password
            // 
            password.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Black;
            password.Location = new Point(363, 330);
            password.Name = "password";
            password.PlaceholderText = "Enter password";
            password.Size = new Size(185, 35);
            password.TabIndex = 13;
            password.TextChanged += textBox2_TextChanged;
            password.KeyDown += password_KeyDown;
            // 
            // username
            // 
            username.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.Black;
            username.Location = new Point(363, 224);
            username.Name = "username";
            username.PlaceholderText = "Enter username";
            username.Size = new Size(185, 35);
            username.TabIndex = 12;
            username.TextChanged += textBox1_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = Color.Teal;
            flowLayoutPanel2.Cursor = Cursors.Hand;
            flowLayoutPanel2.Location = new Point(19, 1317);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(158, 60);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(37, 1330);
            pictureBox4.MaximumSize = new Size(50, 50);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(80, 1338);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 2;
            label6.Text = "Logout";
            // 
            // IN
            // 
            IN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            IN.BackColor = SystemColors.Window;
            IN.Cursor = Cursors.Hand;
            IN.FlatAppearance.BorderSize = 0;
            IN.FlatStyle = FlatStyle.Flat;
            IN.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IN.ForeColor = Color.Black;
            IN.Location = new Point(19, 1015);
            IN.MinimumSize = new Size(157, 38);
            IN.Name = "IN";
            IN.Size = new Size(157, 38);
            IN.TabIndex = 1;
            IN.Text = "IN";
            IN.UseVisualStyleBackColor = false;
            // 
            // OUT
            // 
            OUT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OUT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OUT.BackColor = Color.WhiteSmoke;
            OUT.Cursor = Cursors.Hand;
            OUT.FlatAppearance.BorderSize = 0;
            OUT.FlatStyle = FlatStyle.Flat;
            OUT.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OUT.ForeColor = Color.Black;
            OUT.Location = new Point(20, 1077);
            OUT.Name = "OUT";
            OUT.Size = new Size(157, 38);
            OUT.TabIndex = 3;
            OUT.Text = "OUT";
            OUT.UseVisualStyleBackColor = false;
            // 
            // inventory
            // 
            inventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inventory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            inventory.BackColor = Color.WhiteSmoke;
            inventory.Cursor = Cursors.Hand;
            inventory.FlatAppearance.BorderSize = 0;
            inventory.FlatStyle = FlatStyle.Flat;
            inventory.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inventory.ForeColor = Color.Black;
            inventory.Location = new Point(19, 1138);
            inventory.Name = "inventory";
            inventory.Size = new Size(157, 38);
            inventory.TabIndex = 4;
            inventory.Text = "INVENTORY";
            inventory.UseVisualStyleBackColor = false;
            // 
            // report
            // 
            report.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            report.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            report.BackColor = Color.WhiteSmoke;
            report.Cursor = Cursors.Hand;
            report.FlatAppearance.BorderSize = 0;
            report.FlatStyle = FlatStyle.Flat;
            report.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            report.ForeColor = Color.Black;
            report.Location = new Point(19, 1199);
            report.Name = "report";
            report.Size = new Size(157, 38);
            report.TabIndex = 5;
            report.Text = "REPORT";
            report.UseVisualStyleBackColor = false;
            // 
            // admin_button
            // 
            admin_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            admin_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            admin_button.BackColor = Color.WhiteSmoke;
            admin_button.Cursor = Cursors.Hand;
            admin_button.FlatAppearance.BorderSize = 0;
            admin_button.FlatStyle = FlatStyle.Flat;
            admin_button.Font = new Font("Bosch Office Sans", 8F, FontStyle.Regular, GraphicsUnit.Point);
            admin_button.ForeColor = Color.Black;
            admin_button.Location = new Point(19, 1263);
            admin_button.Name = "admin_button";
            admin_button.Size = new Size(157, 38);
            admin_button.TabIndex = 6;
            admin_button.Text = "AUTHORISATION";
            admin_button.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(admin_button);
            panel1.Controls.Add(report);
            panel1.Controls.Add(inventory);
            panel1.Controls.Add(OUT);
            panel1.Controls.Add(IN);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(400, 1000);
            panel1.MinimumSize = new Size(200, 854);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 899);
            panel1.TabIndex = 14;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1500, 900);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Location = new Point(578, 171);
            Name = "login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sensor Unit FIFO System";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox password;
        private TextBox username;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Buttons.RoundButton login_button;
        private Label label5;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox4;
        private Label label6;
        private Buttons.RoundButton IN;
        private Buttons.RoundButton OUT;
        private Buttons.RoundButton inventory;
        private Buttons.RoundButton report;
        private Buttons.RoundButton admin_button;
        private Panel panel1;
    }
}
