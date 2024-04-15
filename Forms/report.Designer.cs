namespace ReelManagement
{
    partial class report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            flowLayoutPanel1 = new FlowLayoutPanel();
            report_display = new DataGridView();
            from_lbl = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            ClearSelections = new PictureBox();
            filter_btn = new Buttons.RoundButton();
            type_no = new ComboBox();
            label3 = new Label();
            txn_type = new ComboBox();
            label2 = new Label();
            ToDate = new DateTimePicker();
            label1 = new Label();
            FromDate = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)report_display).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClearSelections).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 179, 168);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1500, 48);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // report_display
            // 
            report_display.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            report_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            report_display.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            report_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            report_display.EditMode = DataGridViewEditMode.EditProgrammatically;
            report_display.Location = new Point(112, 197);
            report_display.Margin = new Padding(3, 2, 3, 2);
            report_display.Name = "report_display";
            report_display.RowHeadersWidth = 62;
            report_display.RowTemplate.Height = 33;
            report_display.Size = new Size(1339, 521);
            report_display.TabIndex = 11;
            // 
            // from_lbl
            // 
            from_lbl.AutoSize = true;
            from_lbl.Location = new Point(62, 23);
            from_lbl.Name = "from_lbl";
            from_lbl.Size = new Size(51, 20);
            from_lbl.TabIndex = 15;
            from_lbl.Text = "From";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(type_no);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txn_type);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ToDate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(FromDate);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(from_lbl);
            panel1.Location = new Point(112, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 100);
            panel1.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Controls.Add(ClearSelections);
            panel4.Controls.Add(filter_btn);
            panel4.Location = new Point(628, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 97);
            panel4.TabIndex = 35;
            // 
            // ClearSelections
            // 
            ClearSelections.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearSelections.Image = (Image)resources.GetObject("ClearSelections.Image");
            ClearSelections.Location = new Point(142, 27);
            ClearSelections.Name = "ClearSelections";
            ClearSelections.Size = new Size(40, 38);
            ClearSelections.SizeMode = PictureBoxSizeMode.StretchImage;
            ClearSelections.TabIndex = 32;
            ClearSelections.TabStop = false;
            ClearSelections.Click += ClearSelections_Click;
            // 
            // filter_btn
            // 
            filter_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            filter_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filter_btn.BackColor = Color.FromArgb(32, 179, 168);
            filter_btn.Cursor = Cursors.Hand;
            filter_btn.FlatAppearance.BorderSize = 0;
            filter_btn.FlatStyle = FlatStyle.Flat;
            filter_btn.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filter_btn.ForeColor = Color.Black;
            filter_btn.Location = new Point(9, 27);
            filter_btn.Name = "filter_btn";
            filter_btn.Size = new Size(115, 38);
            filter_btn.TabIndex = 30;
            filter_btn.Text = "Apply";
            filter_btn.UseVisualStyleBackColor = false;
            filter_btn.Click += filter_btn_Click;
            // 
            // type_no
            // 
            type_no.FormattingEnabled = true;
            type_no.Items.AddRange(new object[] { "F0C12H1266", "F0C12H1267 ", "F0C12H1268", "F0C12H1269", "F00C1H3182", "F00C1H3183", "F00C1H3184", "F00C1H3185" });
            type_no.Location = new Point(390, 58);
            type_no.Name = "type_no";
            type_no.Size = new Size(182, 28);
            type_no.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 63);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 22;
            label3.Text = "Type No";
            // 
            // txn_type
            // 
            txn_type.FormattingEnabled = true;
            txn_type.Items.AddRange(new object[] { "IN", "OUT" });
            txn_type.Location = new Point(390, 18);
            txn_type.Name = "txn_type";
            txn_type.Size = new Size(182, 28);
            txn_type.TabIndex = 21;

            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 23);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 20;
            label2.Text = "Txn Type";
            // 
            // ToDate
            // 
            ToDate.Format = DateTimePickerFormat.Short;
            ToDate.Location = new Point(119, 58);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(124, 28);
            ToDate.TabIndex = 19;
            ToDate.Value = new DateTime(2024, 4, 11, 0, 0, 0, 0);

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 64);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 18;
            label1.Text = "To";
            // 
            // FromDate
            // 
            FromDate.Format = DateTimePickerFormat.Short;
            FromDate.Location = new Point(119, 18);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(124, 28);
            FromDate.TabIndex = 17;
            FromDate.Value = new DateTime(2024, 4, 13, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1500, 720);
            Controls.Add(panel1);
            Controls.Add(report_display);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "report";
            Padding = new Padding(0, 48, 0, 0);
            StartPosition = FormStartPosition.CenterParent;
            Text = "report";
            ((System.ComponentModel.ISupportInitialize)report_display).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClearSelections).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView report_display;
        private Label from_lbl;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DateTimePicker FromDate;
        private ComboBox type_no;
        private Label label3;
        private ComboBox txn_type;
        private Label label2;
        private DateTimePicker ToDate;
        private Label label1;
        private Panel panel4;
        private PictureBox ClearSelections;
        private Buttons.RoundButton filter_btn;
    }
}
