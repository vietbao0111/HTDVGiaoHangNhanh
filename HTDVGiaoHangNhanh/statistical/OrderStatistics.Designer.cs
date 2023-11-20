namespace HTDVGiaoHangNhanh.statistical
{
    partial class OrderStatistics
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTitle = new Panel();
            lblTitle = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            lblThang = new Label();
            lblNam = new Label();
            lblLoaiThongKe = new Label();
            cboThang = new Guna.UI2.WinForms.Guna2ComboBox();
            cboLoaiThongKe = new Guna.UI2.WinForms.Guna2ComboBox();
            numNam = new Guna.UI2.WinForms.Guna2NumericUpDown();
            btnAns = new Guna.UI2.WinForms.Guna2Button();
            dgvDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            lblStatus = new Label();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.GreenYellow;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(786, 46);
            pnlTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(300, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Thống kê đơn hàng";
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 3;
            btnBack.CustomizableEdges = customizableEdges1;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.Gold;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 69);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(117, 39);
            btnBack.TabIndex = 28;
            btnBack.Text = "Trở về";
            btnBack.Click += btnBack_Click;
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblThang.Location = new Point(156, 79);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(51, 17);
            lblThang.TabIndex = 29;
            lblThang.Text = "Tháng: ";
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNam.Location = new Point(283, 79);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(43, 17);
            lblNam.TabIndex = 30;
            lblNam.Text = "Năm: ";
            // 
            // lblLoaiThongKe
            // 
            lblLoaiThongKe.AutoSize = true;
            lblLoaiThongKe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoaiThongKe.Location = new Point(423, 79);
            lblLoaiThongKe.Name = "lblLoaiThongKe";
            lblLoaiThongKe.Size = new Size(94, 17);
            lblLoaiThongKe.TabIndex = 31;
            lblLoaiThongKe.Text = "Loại thống kê: ";
            // 
            // cboThang
            // 
            cboThang.BackColor = Color.Transparent;
            cboThang.BorderRadius = 3;
            cboThang.CustomizableEdges = customizableEdges3;
            cboThang.DrawMode = DrawMode.OwnerDrawFixed;
            cboThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThang.FocusedColor = Color.FromArgb(94, 148, 255);
            cboThang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboThang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboThang.ForeColor = Color.FromArgb(68, 88, 112);
            cboThang.FormattingEnabled = true;
            cboThang.ItemHeight = 30;
            cboThang.Location = new Point(213, 69);
            cboThang.Name = "cboThang";
            cboThang.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cboThang.Size = new Size(64, 36);
            cboThang.TabIndex = 32;
            // 
            // cboLoaiThongKe
            // 
            cboLoaiThongKe.BackColor = Color.Transparent;
            cboLoaiThongKe.BorderRadius = 3;
            cboLoaiThongKe.CustomizableEdges = customizableEdges5;
            cboLoaiThongKe.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoaiThongKe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiThongKe.FocusedColor = Color.FromArgb(94, 148, 255);
            cboLoaiThongKe.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboLoaiThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboLoaiThongKe.ForeColor = Color.FromArgb(68, 88, 112);
            cboLoaiThongKe.FormattingEnabled = true;
            cboLoaiThongKe.ItemHeight = 30;
            cboLoaiThongKe.Location = new Point(523, 69);
            cboLoaiThongKe.Name = "cboLoaiThongKe";
            cboLoaiThongKe.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboLoaiThongKe.Size = new Size(247, 36);
            cboLoaiThongKe.TabIndex = 33;
            // 
            // numNam
            // 
            numNam.BackColor = Color.Transparent;
            numNam.BorderRadius = 3;
            numNam.Cursor = Cursors.IBeam;
            numNam.CustomizableEdges = customizableEdges7;
            numNam.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numNam.ForeColor = Color.FromArgb(126, 137, 149);
            numNam.Location = new Point(332, 69);
            numNam.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numNam.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numNam.Name = "numNam";
            numNam.ShadowDecoration.CustomizableEdges = customizableEdges8;
            numNam.Size = new Size(73, 36);
            numNam.TabIndex = 34;
            numNam.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // btnAns
            // 
            btnAns.BorderRadius = 3;
            btnAns.CustomizableEdges = customizableEdges9;
            btnAns.DisabledState.BorderColor = Color.DarkGray;
            btnAns.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAns.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAns.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAns.FillColor = Color.FromArgb(255, 192, 128);
            btnAns.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAns.ForeColor = Color.White;
            btnAns.Location = new Point(653, 111);
            btnAns.Name = "btnAns";
            btnAns.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAns.Size = new Size(117, 39);
            btnAns.TabIndex = 35;
            btnAns.Text = "Trở về";
            // 
            // dgvDonHang
            // 
            dgvDonHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDonHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDonHang.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDonHang.GridColor = Color.FromArgb(231, 229, 255);
            dgvDonHang.ImeMode = ImeMode.NoControl;
            dgvDonHang.Location = new Point(12, 153);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.ReadOnly = true;
            dgvDonHang.RowHeadersVisible = false;
            dgvDonHang.RowTemplate.Height = 25;
            dgvDonHang.Size = new Size(758, 285);
            dgvDonHang.TabIndex = 36;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDonHang.ThemeStyle.BackColor = Color.White;
            dgvDonHang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDonHang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDonHang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDonHang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDonHang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDonHang.ThemeStyle.HeaderStyle.Height = 23;
            dgvDonHang.ThemeStyle.ReadOnly = true;
            dgvDonHang.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDonHang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDonHang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDonHang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDonHang.ThemeStyle.RowsStyle.Height = 25;
            dgvDonHang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDonHang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(9, 441);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 15);
            lblStatus.TabIndex = 37;
            lblStatus.Text = "0 đơn hàng";
            // 
            // OrderStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 468);
            Controls.Add(lblStatus);
            Controls.Add(dgvDonHang);
            Controls.Add(btnAns);
            Controls.Add(numNam);
            Controls.Add(cboLoaiThongKe);
            Controls.Add(cboThang);
            Controls.Add(lblLoaiThongKe);
            Controls.Add(lblNam);
            Controls.Add(lblThang);
            Controls.Add(btnBack);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderStatistics";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNam).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Label lblThang;
        private Label lblNam;
        private Label lblLoaiThongKe;
        private Guna.UI2.WinForms.Guna2ComboBox cboThang;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiThongKe;
        private Guna.UI2.WinForms.Guna2NumericUpDown numNam;
        private Guna.UI2.WinForms.Guna2Button btnAns;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonHang;
        private Label lblStatus;
    }
}