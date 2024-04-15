namespace ReelManagement.Forms
{
    partial class edit_users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_users));
            flowLayoutPanel1 = new FlowLayoutPanel();
            user_info = new DataGridView();
            searchbox = new TextBox();
            panel1 = new Panel();
            edit_ac = new Buttons.RoundButton();
            delete_ac = new Buttons.RoundButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            user_name = new TextBox();
            usr_role = new TextBox();
            pwd = new TextBox();
            pictureBox2 = new PictureBox();
            search_btn = new Buttons.RoundButton();
            refresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)user_info).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 179, 168);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1500, 60);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // user_info
            // 
            user_info.AllowUserToAddRows = false;
            user_info.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            user_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            user_info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            user_info.EditMode = DataGridViewEditMode.EditProgrammatically;
            user_info.Location = new Point(308, 299);
            user_info.MaximumSize = new Size(1700, 800);
            user_info.MinimumSize = new Size(1008, 452);
            user_info.Name = "user_info";
            user_info.RowHeadersWidth = 62;
            user_info.RowTemplate.Height = 33;
            user_info.Size = new Size(1164, 589);
            user_info.TabIndex = 12;
            user_info.CellMouseClick += user_info_CellMouseClick;
            // 
            // searchbox
            // 
            searchbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchbox.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchbox.ForeColor = Color.DimGray;
            searchbox.Location = new Point(5, 12);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(304, 30);
            searchbox.TabIndex = 13;
            searchbox.Text = "Search";
            searchbox.TextAlign = HorizontalAlignment.Right;
            searchbox.Click += searchbox_Click;
            searchbox.TextChanged += searchbox_TextChanged;
            searchbox.KeyDown += searchbox_KeyDown;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(searchbox);
            panel1.Location = new Point(348, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 55);
            panel1.TabIndex = 14;
            // 
            // edit_ac
            // 
            edit_ac.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edit_ac.BackColor = Color.FromArgb(33, 228, 166);
            edit_ac.Cursor = Cursors.Hand;
            edit_ac.FlatAppearance.BorderSize = 0;
            edit_ac.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 171, 127);
            edit_ac.FlatStyle = FlatStyle.Flat;
            edit_ac.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            edit_ac.ForeColor = Color.Black;
            edit_ac.Location = new Point(1101, 115);
            edit_ac.Name = "edit_ac";
            edit_ac.Size = new Size(171, 44);
            edit_ac.TabIndex = 15;
            edit_ac.Text = "Edit";
            edit_ac.UseVisualStyleBackColor = false;
            edit_ac.Click += edit_ac_Click;
            // 
            // delete_ac
            // 
            delete_ac.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            delete_ac.BackColor = Color.FromArgb(230, 41, 70);
            delete_ac.Cursor = Cursors.Hand;
            delete_ac.FlatAppearance.BorderSize = 0;
            delete_ac.FlatAppearance.MouseOverBackColor = Color.FromArgb(188, 34, 55);
            delete_ac.FlatStyle = FlatStyle.Flat;
            delete_ac.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            delete_ac.ForeColor = Color.Black;
            delete_ac.Location = new Point(1283, 111);
            delete_ac.Name = "delete_ac";
            delete_ac.Size = new Size(171, 44);
            delete_ac.TabIndex = 16;
            delete_ac.Text = "Delete";
            delete_ac.UseVisualStyleBackColor = false;
            delete_ac.Click += delete_ac_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel2.Location = new Point(329, 96);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(755, 197);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(355, 192);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(709, 192);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 17;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(355, 242);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 18;
            label3.Text = "User Role";
            // 
            // user_name
            // 
            user_name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            user_name.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            user_name.Location = new Point(456, 192);
            user_name.Name = "user_name";
            user_name.Size = new Size(210, 30);
            user_name.TabIndex = 14;
            // 
            // usr_role
            // 
            usr_role.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            usr_role.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usr_role.Location = new Point(456, 244);
            usr_role.Name = "usr_role";
            usr_role.Size = new Size(210, 30);
            usr_role.TabIndex = 19;
            // 
            // pwd
            // 
            pwd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pwd.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pwd.Location = new Point(813, 192);
            pwd.Name = "pwd";
            pwd.Size = new Size(210, 30);
            pwd.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(32, 179, 168);
            pictureBox2.Image = Properties.Resources.icons8_search_50;
            pictureBox2.Location = new Point(682, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // search_btn
            // 
            search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_btn.BackColor = Color.FromArgb(32, 179, 168);
            search_btn.Cursor = Cursors.Hand;
            search_btn.FlatAppearance.BorderSize = 0;
            search_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 179, 168);
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            search_btn.ForeColor = Color.Black;
            search_btn.Location = new Point(663, 110);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(70, 55);
            search_btn.TabIndex = 25;
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += roundButton3_Click;
            // 
            // refresh
            // 
            refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refresh.BackColor = SystemColors.Control;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(752, 119);
            refresh.Name = "refresh";
            refresh.Size = new Size(36, 36);
            refresh.SizeMode = PictureBoxSizeMode.StretchImage;
            refresh.TabIndex = 26;
            refresh.TabStop = false;
            refresh.Click += pictureBox1_Click;
            // 
            // edit_users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1500, 900);
            Controls.Add(refresh);
            Controls.Add(pictureBox2);
            Controls.Add(search_btn);
            Controls.Add(pwd);
            Controls.Add(usr_role);
            Controls.Add(user_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(delete_ac);
            Controls.Add(edit_ac);
            Controls.Add(user_info);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "edit_users";
            StartPosition = FormStartPosition.CenterParent;
            Text = "edit_users";
            ((System.ComponentModel.ISupportInitialize)user_info).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView user_info;
        private TextBox searchbox;
        private Panel panel1;
        private Buttons.RoundButton edit_ac;
        private Buttons.RoundButton delete_ac;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox user_name;
        private TextBox usr_role;
        private TextBox pwd;
        private PictureBox pictureBox2;
        private Buttons.RoundButton search_btn;
        private PictureBox refresh;
    }
}
