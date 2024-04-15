namespace ReelManagement
{
    partial class mainmenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            report = new Buttons.RoundButton();
            inventory = new Buttons.RoundButton();
            OUT = new Buttons.RoundButton();
            IN = new Buttons.RoundButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            main_nav = new Panel();
            Bosch_Logo = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            role_lbl = new Label();
            username_lbl = new Label();
            admin_button = new Buttons.RoundButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Title = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            timelbl = new Label();
            datetime_timer = new System.Windows.Forms.Timer(components);
            top_label = new Label();
            VDS_Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            main_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Bosch_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VDS_Logo).BeginInit();
            SuspendLayout();
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
            report.Location = new Point(19, 410);
            report.Name = "report";
            report.Size = new Size(157, 38);
            report.TabIndex = 5;
            report.Text = "REPORT";
            report.UseVisualStyleBackColor = false;
            report.Click += report_Click;
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
            inventory.Location = new Point(19, 349);
            inventory.Name = "inventory";
            inventory.Size = new Size(157, 38);
            inventory.TabIndex = 4;
            inventory.Text = "INVENTORY";
            inventory.UseVisualStyleBackColor = false;
            inventory.Click += inventory_Click;
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
            OUT.Location = new Point(20, 288);
            OUT.Name = "OUT";
            OUT.Size = new Size(157, 38);
            OUT.TabIndex = 3;
            OUT.Text = "OUT";
            OUT.UseVisualStyleBackColor = false;
            OUT.Click += OUT_Click;
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
            IN.Location = new Point(19, 226);
            IN.MinimumSize = new Size(157, 38);
            IN.Name = "IN";
            IN.Size = new Size(157, 38);
            IN.TabIndex = 1;
            IN.Text = "IN";
            IN.UseVisualStyleBackColor = false;
            IN.Click += IN_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 549);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Logout";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 541);
            pictureBox1.MaximumSize = new Size(50, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // main_nav
            // 
            main_nav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            main_nav.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            main_nav.BackColor = Color.Teal;
            main_nav.Controls.Add(Bosch_Logo);
            main_nav.Controls.Add(label2);
            main_nav.Controls.Add(pictureBox3);
            main_nav.Controls.Add(flowLayoutPanel3);
            main_nav.Controls.Add(role_lbl);
            main_nav.Controls.Add(username_lbl);
            main_nav.Controls.Add(admin_button);
            main_nav.Controls.Add(report);
            main_nav.Controls.Add(inventory);
            main_nav.Controls.Add(OUT);
            main_nav.Controls.Add(IN);
            main_nav.Controls.Add(label1);
            main_nav.Controls.Add(pictureBox1);
            main_nav.Controls.Add(flowLayoutPanel2);
            main_nav.Location = new Point(0, 1);
            main_nav.MaximumSize = new Size(400, 1000);
            main_nav.MinimumSize = new Size(200, 854);
            main_nav.Name = "main_nav";
            main_nav.Size = new Size(200, 854);
            main_nav.TabIndex = 13;
            // 
            // Bosch_Logo
            // 
            Bosch_Logo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Bosch_Logo.Image = (Image)resources.GetObject("Bosch_Logo.Image");
            Bosch_Logo.Location = new Point(0, 0);
            Bosch_Logo.MinimumSize = new Size(121, 117);
            Bosch_Logo.Name = "Bosch_Logo";
            Bosch_Logo.Size = new Size(200, 133);
            Bosch_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Bosch_Logo.TabIndex = 21;
            Bosch_Logo.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(99, 614);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 20;
            label2.Text = "Help";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 609);
            pictureBox3.MaximumSize = new Size(50, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.BackColor = Color.Teal;
            flowLayoutPanel3.Cursor = Cursors.Hand;
            flowLayoutPanel3.Location = new Point(20, 600);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(158, 47);
            flowLayoutPanel3.TabIndex = 16;
            // 
            // role_lbl
            // 
            role_lbl.AutoSize = true;
            role_lbl.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            role_lbl.Location = new Point(55, 174);
            role_lbl.Name = "role_lbl";
            role_lbl.Size = new Size(84, 20);
            role_lbl.TabIndex = 17;
            role_lbl.Text = "user_role";
            role_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.Location = new Point(55, 145);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(99, 22);
            username_lbl.TabIndex = 16;
            username_lbl.Text = "username";
            username_lbl.TextAlign = ContentAlignment.MiddleCenter;
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
            admin_button.Location = new Point(19, 474);
            admin_button.Name = "admin_button";
            admin_button.Size = new Size(157, 38);
            admin_button.TabIndex = 6;
            admin_button.Text = "AUTHORIZATION";
            admin_button.UseVisualStyleBackColor = false;
            admin_button.Click += admin_button_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = Color.Teal;
            flowLayoutPanel2.Cursor = Cursors.Hand;
            flowLayoutPanel2.Location = new Point(20, 534);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(158, 47);
            flowLayoutPanel2.TabIndex = 15;
            flowLayoutPanel2.Click += flowLayoutPanel2_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.BackColor = Color.FromArgb(32, 179, 168);
            Title.Font = new Font("Bosch Office Sans", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.Black;
            Title.Location = new Point(619, 2);
            Title.Name = "Title";
            Title.Size = new Size(382, 36);
            Title.TabIndex = 18;
            Title.Text = "Sensor Unit FIFO System";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 179, 168);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1480, 82);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // timelbl
            // 
            timelbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timelbl.BackColor = Color.FromArgb(32, 179, 168);
            timelbl.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            timelbl.Location = new Point(1301, 14);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(150, 38);
            timelbl.TabIndex = 15;
            // 
            // datetime_timer
            // 
            datetime_timer.Tick += datetime_timer_Tick;
            // 
            // top_label
            // 
            top_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            top_label.AutoSize = true;
            top_label.BackColor = Color.FromArgb(32, 179, 168);
            top_label.Font = new Font("Bosch Office Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            top_label.Location = new Point(675, 43);
            top_label.Name = "top_label";
            top_label.Size = new Size(254, 31);
            top_label.TabIndex = 20;
            top_label.Text = "Output Transaction";
            top_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VDS_Logo
            // 
            VDS_Logo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VDS_Logo.BackColor = Color.FromArgb(32, 179, 168);
            VDS_Logo.Image = (Image)resources.GetObject("VDS_Logo.Image");
            VDS_Logo.Location = new Point(1281, 0);
            VDS_Logo.Name = "VDS_Logo";
            VDS_Logo.Size = new Size(174, 82);
            VDS_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            VDS_Logo.TabIndex = 21;
            VDS_Logo.TabStop = false;
            // 
            // mainmenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1478, 844);
            Controls.Add(VDS_Logo);
            Controls.Add(Title);
            Controls.Add(top_label);
            Controls.Add(timelbl);
            Controls.Add(main_nav);
            Controls.Add(flowLayoutPanel1);
            MinimumSize = new Size(1500, 900);
            Name = "mainmenu";
            Text = "Sensor Unit FIFO System";
            Load += mainmenu_Load;
            SizeChanged += mainmenu_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            main_nav.ResumeLayout(false);
            main_nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Bosch_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)VDS_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Buttons.RoundButton report;
        private Buttons.RoundButton inventory;
        private Buttons.RoundButton OUT;
        private Buttons.RoundButton IN;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel main_nav;
        private Buttons.RoundButton admin_button;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label timelbl;
        private Label role_lbl;
        private Label username_lbl;
        private System.Windows.Forms.Timer datetime_timer;
        private Label top_label;
        private Label Title;
        private Label label2;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox VDS_Logo;
        private PictureBox Bosch_Logo;
    }
}
