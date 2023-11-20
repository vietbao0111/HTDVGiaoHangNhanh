namespace HTDVGiaoHangNhanh.statistical
{
    partial class TotalRevenueStatistics
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTitle = new Panel();
            lblTitle = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            numNam = new Guna.UI2.WinForms.Guna2NumericUpDown();
            cboThang = new Guna.UI2.WinForms.Guna2ComboBox();
            lblNam = new Label();
            lblThang = new Label();
            btnAns = new Guna.UI2.WinForms.Guna2Button();
            lblTongDHTonKho = new Label();
            lblSoDHGiaoThanhCong = new Label();
            lblTongDHHoanTra = new Label();
            lblTongDoanhThu = new Label();
            lblStatus = new Label();
            dgvDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
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
            pnlTitle.Size = new Size(800, 40);
            pnlTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(266, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(269, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Tổng doanh thu trong tháng";
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
            btnBack.Location = new Point(20, 67);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(117, 39);
            btnBack.TabIndex = 29;
            btnBack.Text = "Trở về";
            btnBack.Click += btnBack_Click;
            // 
            // numNam
            // 
            numNam.BackColor = Color.Transparent;
            numNam.BorderRadius = 3;
            numNam.Cursor = Cursors.IBeam;
            numNam.CustomizableEdges = customizableEdges3;
            numNam.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numNam.ForeColor = Color.FromArgb(126, 137, 149);
            numNam.Location = new Point(446, 66);
            numNam.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numNam.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numNam.Name = "numNam";
            numNam.ShadowDecoration.CustomizableEdges = customizableEdges4;
            numNam.Size = new Size(73, 36);
            numNam.TabIndex = 38;
            numNam.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // cboThang
            // 
            cboThang.BackColor = Color.Transparent;
            cboThang.BorderRadius = 3;
            cboThang.CustomizableEdges = customizableEdges5;
            cboThang.DrawMode = DrawMode.OwnerDrawFixed;
            cboThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThang.FocusedColor = Color.FromArgb(94, 148, 255);
            cboThang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboThang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboThang.ForeColor = Color.FromArgb(68, 88, 112);
            cboThang.FormattingEnabled = true;
            cboThang.ItemHeight = 30;
            cboThang.Location = new Point(327, 66);
            cboThang.Name = "cboThang";
            cboThang.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboThang.Size = new Size(64, 36);
            cboThang.TabIndex = 37;
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNam.Location = new Point(397, 76);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(43, 17);
            lblNam.TabIndex = 36;
            lblNam.Text = "Năm: ";
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblThang.Location = new Point(270, 76);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(51, 17);
            lblThang.TabIndex = 35;
            lblThang.Text = "Tháng: ";
            // 
            // btnAns
            // 
            btnAns.BorderRadius = 3;
            btnAns.CustomizableEdges = customizableEdges7;
            btnAns.DisabledState.BorderColor = Color.DarkGray;
            btnAns.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAns.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAns.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAns.FillColor = Color.FromArgb(255, 192, 128);
            btnAns.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAns.ForeColor = Color.White;
            btnAns.Location = new Point(671, 67);
            btnAns.Name = "btnAns";
            btnAns.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAns.Size = new Size(117, 39);
            btnAns.TabIndex = 39;
            btnAns.Text = "Kết quả";
            // 
            // lblTongDHTonKho
            // 
            lblTongDHTonKho.AutoSize = true;
            lblTongDHTonKho.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongDHTonKho.Location = new Point(522, 127);
            lblTongDHTonKho.Name = "lblTongDHTonKho";
            lblTongDHTonKho.Size = new Size(195, 17);
            lblTongDHTonKho.TabIndex = 40;
            lblTongDHTonKho.Text = "Tổng đơn hàng tồn kho: 0 đồng";
            // 
            // lblSoDHGiaoThanhCong
            // 
            lblSoDHGiaoThanhCong.AutoSize = true;
            lblSoDHGiaoThanhCong.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoDHGiaoThanhCong.Location = new Point(522, 152);
            lblSoDHGiaoThanhCong.Name = "lblSoDHGiaoThanhCong";
            lblSoDHGiaoThanhCong.Size = new Size(246, 17);
            lblSoDHGiaoThanhCong.TabIndex = 41;
            lblSoDHGiaoThanhCong.Text = "Tổng đơn hàng giao thành công: 0 đồng";
            // 
            // lblTongDHHoanTra
            // 
            lblTongDHHoanTra.AutoSize = true;
            lblTongDHHoanTra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongDHHoanTra.Location = new Point(522, 177);
            lblTongDHHoanTra.Name = "lblTongDHHoanTra";
            lblTongDHHoanTra.Size = new Size(215, 17);
            lblTongDHHoanTra.TabIndex = 42;
            lblTongDHHoanTra.Text = "Tổng đơn hàng bị hoàn trả: 0 đồng";
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongDoanhThu.Location = new Point(522, 202);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(150, 17);
            lblTongDoanhThu.TabIndex = 43;
            lblTongDoanhThu.Text = "Tổng doanh thu: 0 đồng";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 428);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 13);
            lblStatus.TabIndex = 44;
            lblStatus.Text = "0 đơn hàng";
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDonHang.GridColor = Color.FromArgb(231, 229, 255);
            dgvDonHang.Location = new Point(20, 127);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.ReadOnly = true;
            dgvDonHang.RowHeadersVisible = false;
            dgvDonHang.RowTemplate.Height = 25;
            dgvDonHang.Size = new Size(496, 290);
            dgvDonHang.TabIndex = 45;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDonHang.ThemeStyle.BackColor = Color.White;
            dgvDonHang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDonHang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDonHang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDonHang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDonHang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDonHang.ThemeStyle.HeaderStyle.Height = 23;
            dgvDonHang.ThemeStyle.ReadOnly = true;
            dgvDonHang.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDonHang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDonHang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDonHang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDonHang.ThemeStyle.RowsStyle.Height = 25;
            dgvDonHang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDonHang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // TotalRevenueStatistics
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDonHang);
            Controls.Add(lblStatus);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(lblTongDHHoanTra);
            Controls.Add(lblSoDHGiaoThanhCong);
            Controls.Add(lblTongDHTonKho);
            Controls.Add(btnAns);
            Controls.Add(numNam);
            Controls.Add(cboThang);
            Controls.Add(lblNam);
            Controls.Add(lblThang);
            Controls.Add(btnBack);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TotalRevenueStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê tổng doanh thu";
            Load += TotalRevenueStatistics_Load;
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
        private Guna.UI2.WinForms.Guna2NumericUpDown numNam;
        private Guna.UI2.WinForms.Guna2ComboBox cboThang;
        private Label lblNam;
        private Label lblThang;
        private Guna.UI2.WinForms.Guna2Button btnAns;
        private Label lblTongDHTonKho;
        private Label lblSoDHGiaoThanhCong;
        private Label lblTongDHHoanTra;
        private Label lblTongDoanhThu;
        private Label lblStatus;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonHang;
    }
}