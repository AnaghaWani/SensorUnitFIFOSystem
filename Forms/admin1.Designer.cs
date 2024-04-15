namespace ReelManagement.Forms
{
    partial class admin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            sidebar = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 179, 168);
            flowLayoutPanel1.Location = new Point(194, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1323, 60);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sidebar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sidebar.BackColor = Color.FromArgb(32, 179, 168);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(pictureBox1);
            sidebar.Controls.Add(panel2);
            sidebar.Location = new Point(194, 0);
            sidebar.MaximumSize = new Size(180, 1000);
            sidebar.MinimumSize = new Size(70, 1000);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(180, 1000);
            sidebar.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(3, 393);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 92);
            panel4.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 35);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 19;
            label3.Text = "Manage";
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(0, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 92);
            panel3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 35);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 19;
            label2.Text = "Edit Users";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 92);
            panel2.TabIndex = 17;
            panel2.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 19;
            label1.Text = "Add Users";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_add_96;
            pictureBox2.Location = new Point(21, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // admin1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1500, 900);
            Controls.Add(sidebar);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "admin1";
            sidebar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel sidebar;
        private Panel panel4;
        private Label label3;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
