namespace ReelManagement
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            flowLayoutPanel1 = new FlowLayoutPanel();
            inventory_display = new DataGridView();
            panel1 = new Panel();
            panel4 = new Panel();
            ClearSelections = new PictureBox();
            filter_btn = new Buttons.RoundButton();
            panel3 = new Panel();
            SelectAll = new CheckBox();
            TypeNo = new CheckedListBox();
            panel2 = new Panel();
            quantity = new Label();
            txn_type = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            ToDate = new DateTimePicker();
            label1 = new Label();
            FromDate = new DateTimePicker();
            from_lbl = new Label();
            panel_F0C12H1266 = new Panel();
            panel6 = new Panel();
            panel_F00C1H3185 = new Panel();
            panel_F00C1H3184 = new Panel();
            panel_F00C1H3183 = new Panel();
            panel_F00C1H3182 = new Panel();
            panel_F0C12H1269 = new Panel();
            panel_F0C12H1268 = new Panel();
            panel_F0C12H1267 = new Panel();
            ((System.ComponentModel.ISupportInitialize)inventory_display).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClearSelections).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 179, 168);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1500, 60);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // inventory_display
            // 
            inventory_display.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inventory_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventory_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventory_display.EditMode = DataGridViewEditMode.EditProgrammatically;
            inventory_display.Location = new Point(458, 524);
            inventory_display.Name = "inventory_display";
            inventory_display.RowHeadersWidth = 62;
            inventory_display.RowTemplate.Height = 33;
            inventory_display.Size = new Size(807, 338);
            inventory_display.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txn_type);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ToDate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(FromDate);
            panel1.Controls.Add(from_lbl);
            panel1.Location = new Point(224, 103);
            panel1.MinimumSize = new Size(540, 367);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 367);
            panel1.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Controls.Add(ClearSelections);
            panel4.Controls.Add(filter_btn);
            panel4.Location = new Point(304, 273);
            panel4.Name = "panel4";
            panel4.Size = new Size(181, 60);
            panel4.TabIndex = 34;
            // 
            // ClearSelections
            // 
            ClearSelections.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearSelections.Image = (Image)resources.GetObject("ClearSelections.Image");
            ClearSelections.Location = new Point(131, 11);
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
            filter_btn.Location = new Point(10, 11);
            filter_btn.Name = "filter_btn";
            filter_btn.Size = new Size(115, 38);
            filter_btn.TabIndex = 30;
            filter_btn.Text = "Apply";
            filter_btn.UseVisualStyleBackColor = false;
            filter_btn.Click += IN_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(SelectAll);
            panel3.Controls.Add(TypeNo);
            panel3.Location = new Point(304, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 250);
            panel3.TabIndex = 33;
            // 
            // SelectAll
            // 
            SelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SelectAll.AutoSize = true;
            SelectAll.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SelectAll.Location = new Point(14, 219);
            SelectAll.Name = "SelectAll";
            SelectAll.Size = new Size(117, 26);
            SelectAll.TabIndex = 31;
            SelectAll.Text = "Select All";
            SelectAll.UseVisualStyleBackColor = true;
            SelectAll.CheckedChanged += SelectAll_CheckedChanged;
            // 
            // TypeNo
            // 
            TypeNo.BackColor = SystemColors.Control;
            TypeNo.Font = new Font("Bosch Office Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TypeNo.FormattingEnabled = true;
            TypeNo.Items.AddRange(new object[] { "F0C12H1266", "F0C12H1267 ", "F0C12H1268", "F0C12H1269", "F00C1H3182", "F00C1H3183", "F00C1H3184", "F00C1H3185" });
            TypeNo.Location = new Point(10, 9);
            TypeNo.Name = "TypeNo";
            TypeNo.Size = new Size(145, 204);
            TypeNo.TabIndex = 29;
            TypeNo.ThreeDCheckBoxes = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 179, 168);
            panel2.Controls.Add(quantity);
            panel2.Location = new Point(71, 237);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 73);
            panel2.TabIndex = 28;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.BackColor = Color.FromArgb(32, 179, 168);
            quantity.Font = new Font("Bosch Office Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            quantity.Location = new Point(44, 21);
            quantity.Name = "quantity";
            quantity.Size = new Size(94, 31);
            quantity.TabIndex = 26;
            quantity.Text = "87687";
            // 
            // txn_type
            // 
            txn_type.FormattingEnabled = true;
            txn_type.Items.AddRange(new object[] { "IN", "OUT" });
            txn_type.Location = new Point(110, 131);
            txn_type.Name = "txn_type";
            txn_type.Size = new Size(176, 33);
            txn_type.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 136);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 24;
            label2.Text = "Txn Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bosch Office Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(115, 203);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 27;
            label4.Text = "Quantity";
            // 
            // ToDate
            // 
            ToDate.Format = DateTimePickerFormat.Short;
            ToDate.Location = new Point(87, 71);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(142, 31);
            ToDate.TabIndex = 23;
            ToDate.Value = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 77);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 22;
            label1.Text = "To";
            // 
            // FromDate
            // 
            FromDate.Format = DateTimePickerFormat.Short;
            FromDate.Location = new Point(87, 31);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(142, 31);
            FromDate.TabIndex = 21;
            FromDate.Value = new DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // from_lbl
            // 
            from_lbl.AutoSize = true;
            from_lbl.Location = new Point(30, 36);
            from_lbl.Name = "from_lbl";
            from_lbl.Size = new Size(54, 25);
            from_lbl.TabIndex = 20;
            from_lbl.Text = "From";
            // 
            // panel_F0C12H1266
            // 
            panel_F0C12H1266.BackColor = Color.FromArgb(224, 224, 224);
            panel_F0C12H1266.Location = new Point(7, 35);
            panel_F0C12H1266.Name = "panel_F0C12H1266";
            panel_F0C12H1266.Size = new Size(160, 24);
            panel_F0C12H1266.TabIndex = 13;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(32, 179, 168);
            panel6.Controls.Add(panel_F00C1H3185);
            panel6.Controls.Add(panel_F00C1H3184);
            panel6.Controls.Add(panel_F00C1H3183);
            panel6.Controls.Add(panel_F00C1H3182);
            panel6.Controls.Add(panel_F0C12H1269);
            panel6.Controls.Add(panel_F0C12H1268);
            panel6.Controls.Add(panel_F0C12H1267);
            panel6.Controls.Add(panel_F0C12H1266);
            panel6.Location = new Point(1271, 524);
            panel6.Name = "panel6";
            panel6.Size = new Size(176, 338);
            panel6.TabIndex = 14;
            // 
            // panel_F00C1H3185
            // 
            panel_F00C1H3185.BackColor = Color.FromArgb(224, 224, 224);
            panel_F00C1H3185.Location = new Point(7, 271);
            panel_F00C1H3185.Name = "panel_F00C1H3185";
            panel_F00C1H3185.Size = new Size(160, 24);
            panel_F00C1H3185.TabIndex = 14;
            // 
            // panel_F00C1H3184
            // 
            panel_F00C1H3184.BackColor = Color.FromArgb(224, 224, 224);
            panel_F00C1H3184.Location = new Point(7, 235);
            panel_F00C1H3184.Name = "panel_F00C1H3184";
            panel_F00C1H3184.Size = new Size(160, 24);
            panel_F00C1H3184.TabIndex = 14;
            // 
            // panel_F00C1H3183
            // 
            panel_F00C1H3183.BackColor = Color.FromArgb(224, 224, 224);
            panel_F00C1H3183.Location = new Point(7, 202);
            panel_F00C1H3183.Name = "panel_F00C1H3183";
            panel_F00C1H3183.Size = new Size(160, 24);
            panel_F00C1H3183.TabIndex = 14;
            // 
            // panel_F00C1H3182
            // 
            panel_F00C1H3182.BackColor = Color.FromArgb(224, 224, 224);
            panel_F00C1H3182.Location = new Point(7, 170);
            panel_F00C1H3182.Name = "panel_F00C1H3182";
            panel_F00C1H3182.Size = new Size(160, 24);
            panel_F00C1H3182.TabIndex = 14;
            // 
            // panel_F0C12H1269
            // 
            panel_F0C12H1269.BackColor = Color.FromArgb(224, 224, 224);
            panel_F0C12H1269.Location = new Point(7, 137);
            panel_F0C12H1269.Name = "panel_F0C12H1269";
            panel_F0C12H1269.Size = new Size(160, 24);
            panel_F0C12H1269.TabIndex = 14;
            // 
            // panel_F0C12H1268
            // 
            panel_F0C12H1268.BackColor = Color.FromArgb(224, 224, 224);
            panel_F0C12H1268.Location = new Point(7, 103);
            panel_F0C12H1268.Name = "panel_F0C12H1268";
            panel_F0C12H1268.Size = new Size(160, 24);
            panel_F0C12H1268.TabIndex = 14;
            // 
            // panel_F0C12H1267
            // 
            panel_F0C12H1267.BackColor = Color.FromArgb(224, 224, 224);
            panel_F0C12H1267.Location = new Point(7, 69);
            panel_F0C12H1267.Name = "panel_F0C12H1267";
            panel_F0C12H1267.Size = new Size(160, 24);
            panel_F0C12H1267.TabIndex = 14;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1500, 900);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(inventory_display);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "s";
            ((System.ComponentModel.ISupportInitialize)inventory_display).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClearSelections).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView inventory_display;
        private Panel panel1;
        private DateTimePicker ToDate;
        private Label label1;
        private DateTimePicker FromDate;
        private Label from_lbl;
        private ComboBox txn_type;
        private Label label2;
        private Panel panel2;
        private Label quantity;
        private Label label4;
        private CheckedListBox TypeNo;
        private Buttons.RoundButton filter_btn;
        private CheckBox SelectAll;
        private PictureBox ClearSelections;
        private Panel panel4;
        private Panel panel3;
        private Panel panel_F0C12H1266;
        private Panel panel6;
        private Panel panel_F0C12H1268;
        private Panel panel_F0C12H1267;
        private Panel panel_F00C1H3185;
        private Panel panel_F00C1H3184;
        private Panel panel_F00C1H3183;
        private Panel panel_F00C1H3182;
        private Panel panel_F0C12H1269;
    }
}
