namespace ReelManagement
{
    partial class create_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_account));
            panel2 = new Panel();
            refresh = new PictureBox();
            role = new ComboBox();
            label4 = new Label();
            create_ac = new Buttons.RoundButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            password = new TextBox();
            username = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(refresh);
            panel2.Controls.Add(role);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(create_ac);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Location = new Point(578, 171);
            panel2.MaximumSize = new Size(689, 610);
            panel2.MinimumSize = new Size(669, 599);
            panel2.Name = "panel2";
            panel2.Size = new Size(669, 599);
            panel2.TabIndex = 14;
            // 
            // refresh
            // 
            refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refresh.BackColor = SystemColors.Control;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(594, 45);
            refresh.Name = "refresh";
            refresh.Size = new Size(36, 36);
            refresh.SizeMode = PictureBoxSizeMode.StretchImage;
            refresh.TabIndex = 27;
            refresh.TabStop = false;
            refresh.Click += refresh_Click;
            // 
            // role
            // 
            role.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            role.ForeColor = Color.DimGray;
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "Operator", "Admin", "FLM" });
            role.Location = new Point(322, 253);
            role.Name = "role";
            role.Size = new Size(190, 35);
            role.TabIndex = 22;
            role.Text = "Select";
            role.Click += role_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(233, 259);
            label4.Name = "label4";
            label4.Size = new Size(60, 27);
            label4.TabIndex = 21;
            label4.Text = "Role";
            // 
            // create_ac
            // 
            create_ac.BackColor = SystemColors.Control;
            create_ac.FlatAppearance.BorderSize = 0;
            create_ac.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 179, 168);
            create_ac.FlatStyle = FlatStyle.Flat;
            create_ac.Font = new Font("Bosch Office Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            create_ac.ForeColor = Color.Black;
            create_ac.Location = new Point(205, 448);
            create_ac.Name = "create_ac";
            create_ac.Size = new Size(235, 65);
            create_ac.TabIndex = 12;
            create_ac.Text = "Create";
            create_ac.UseVisualStyleBackColor = false;
            create_ac.Click += roundButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bosch Office Sans", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(189, 82);
            label3.Name = "label3";
            label3.Size = new Size(291, 44);
            label3.TabIndex = 16;
            label3.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(180, 344);
            label2.Name = "label2";
            label2.Size = new Size(116, 27);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(156, 175);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 14;
            label1.Text = "User Name";
            // 
            // password
            // 
            password.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Black;
            password.Location = new Point(322, 341);
            password.Name = "password";
            password.PlaceholderText = "Enter password";
            password.Size = new Size(190, 35);
            password.TabIndex = 13;
            // 
            // username
            // 
            username.Font = new Font("Bosch Office Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.Black;
            username.Location = new Point(322, 172);
            username.Name = "username";
            username.PlaceholderText = "Enter name";
            username.Size = new Size(190, 35);
            username.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 179, 168);
            flowLayoutPanel1.Location = new Point(-80, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1584, 60);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // create_account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1500, 900);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "create_account";
            StartPosition = FormStartPosition.CenterParent;
            Text = "create_account";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)refresh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Buttons.RoundButton create_ac;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox password;
        private TextBox username;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private ComboBox role;
        private PictureBox refresh;
    }
}
