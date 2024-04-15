namespace ReelManagement.Forms
{
    partial class manage_data
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            MinMax_Service = new Panel();
            confirm_btn = new Buttons.RoundButton();
            max_val = new TextBox();
            min_val = new TextBox();
            label4 = new Label();
            minimum = new Label();
            type_no = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            roundButton2 = new Buttons.RoundButton();
            b_no = new TextBox();
            batch_no = new Label();
            label7 = new Label();
            MinMax_Service.SuspendLayout();
            panel1.SuspendLayout();
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
            // MinMax_Service
            // 
            MinMax_Service.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinMax_Service.Controls.Add(confirm_btn);
            MinMax_Service.Controls.Add(max_val);
            MinMax_Service.Controls.Add(min_val);
            MinMax_Service.Controls.Add(label4);
            MinMax_Service.Controls.Add(minimum);
            MinMax_Service.Controls.Add(type_no);
            MinMax_Service.Controls.Add(label3);
            MinMax_Service.Controls.Add(label1);
            MinMax_Service.Location = new Point(465, 206);
            MinMax_Service.Name = "MinMax_Service";
            MinMax_Service.Size = new Size(354, 332);
            MinMax_Service.TabIndex = 12;
            // 
            // confirm_btn
            // 
            confirm_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            confirm_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            confirm_btn.BackColor = Color.FromArgb(32, 179, 168);
            confirm_btn.Cursor = Cursors.Hand;
            confirm_btn.FlatAppearance.BorderSize = 0;
            confirm_btn.FlatStyle = FlatStyle.Flat;
            confirm_btn.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_btn.ForeColor = Color.Black;
            confirm_btn.Location = new Point(96, 280);
            confirm_btn.MinimumSize = new Size(157, 38);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(157, 38);
            confirm_btn.TabIndex = 31;
            confirm_btn.Text = "Save";
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // max_val
            // 
            max_val.Location = new Point(130, 221);
            max_val.Name = "max_val";
            max_val.Size = new Size(185, 31);
            max_val.TabIndex = 30;
            // 
            // min_val
            // 
            min_val.Location = new Point(130, 152);
            min_val.Name = "min_val";
            min_val.Size = new Size(185, 31);
            min_val.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 221);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 28;
            label4.Text = "Maximum";
            // 
            // minimum
            // 
            minimum.AutoSize = true;
            minimum.Location = new Point(42, 155);
            minimum.Name = "minimum";
            minimum.Size = new Size(88, 25);
            minimum.TabIndex = 26;
            minimum.Text = "Minimum";
            // 
            // type_no
            // 
            type_no.FormattingEnabled = true;
            type_no.Items.AddRange(new object[] { "F0C12H1266", "F0C12H1267 ", "F0C12H1268", "F0C12H1269", "F00C1H3182", "F00C1H3183", "F00C1H3184", "F00C1H3185" });
            type_no.Location = new Point(130, 72);
            type_no.Name = "type_no";
            type_no.Size = new Size(182, 33);
            type_no.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 77);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 24;
            label3.Text = "Type No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 21);
            label1.Name = "label1";
            label1.Size = new Size(220, 22);
            label1.TabIndex = 0;
            label1.Text = "Change Min-Max Limits";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(roundButton2);
            panel1.Controls.Add(b_no);
            panel1.Controls.Add(batch_no);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(989, 283);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 199);
            panel1.TabIndex = 13;
            // 
            // roundButton2
            // 
            roundButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            roundButton2.BackColor = Color.FromArgb(32, 179, 168);
            roundButton2.Cursor = Cursors.Hand;
            roundButton2.FlatAppearance.BorderSize = 0;
            roundButton2.FlatStyle = FlatStyle.Flat;
            roundButton2.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            roundButton2.ForeColor = Color.Black;
            roundButton2.Location = new Point(89, 141);
            roundButton2.MinimumSize = new Size(157, 38);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(157, 38);
            roundButton2.TabIndex = 32;
            roundButton2.Text = "Save";
            roundButton2.UseVisualStyleBackColor = false;
            roundButton2.Click += roundButton2_Click;
            // 
            // b_no
            // 
            b_no.Location = new Point(130, 77);
            b_no.Name = "b_no";
            b_no.Size = new Size(185, 31);
            b_no.TabIndex = 30;
            // 
            // batch_no
            // 
            batch_no.AutoSize = true;
            batch_no.Location = new Point(41, 77);
            batch_no.Name = "batch_no";
            batch_no.Size = new Size(84, 25);
            batch_no.TabIndex = 24;
            batch_no.Text = "Batch No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(99, 21);
            label7.Name = "label7";
            label7.Size = new Size(184, 22);
            label7.TabIndex = 0;
            label7.Text = "Manual Transaction";
            // 
            // manage_data
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1500, 900);
            Controls.Add(panel1);
            Controls.Add(MinMax_Service);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "manage_data";
            StartPosition = FormStartPosition.CenterParent;
            Text = "manage_data";
            MinMax_Service.ResumeLayout(false);
            MinMax_Service.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel MinMax_Service;
        private Label label1;
        private ComboBox type_no;
        private Label label3;
        private TextBox max_val;
        private TextBox min_val;
        private Label label4;
        private Label minimum;
        private Buttons.RoundButton confirm_btn;
        private Panel panel1;
        private Buttons.RoundButton roundButton2;
        private TextBox b_no;
        private Label batch_no;
        private Label label7;
    }
}
