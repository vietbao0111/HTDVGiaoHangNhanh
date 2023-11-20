namespace HTDVGiaoHangNhanh
{
    partial class DisplayProductInformation
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTitle = new Panel();
            lblTitle = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            lblMaVanDon = new Label();
            dgvThongTinSanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            lblStatus = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinSanPham).BeginInit();
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
            pnlTitle.Size = new Size(513, 46);
            pnlTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(88, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(336, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Thông tin sản phẩm trong đơn hàng";
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 3;
            btnBack.CustomizableEdges = customizableEdges1;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.Gold;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 59);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(117, 39);
            btnBack.TabIndex = 26;
            btnBack.Text = "Trở về";
            btnBack.Click += btnBack_Click;
            // 
            // lblMaVanDon
            // 
            lblMaVanDon.AutoSize = true;
            lblMaVanDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaVanDon.ForeColor = Color.FromArgb(0, 151, 251);
            lblMaVanDon.Location = new Point(337, 78);
            lblMaVanDon.Name = "lblMaVanDon";
            lblMaVanDon.Size = new Size(164, 17);
            lblMaVanDon.TabIndex = 27;
            lblMaVanDon.Text = "Đơn hàng: Ag5539210714";
            // 
            // dgvThongTinSanPham
            // 
            dgvThongTinSanPham.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvThongTinSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvThongTinSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvThongTinSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvThongTinSanPham.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvThongTinSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvThongTinSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvThongTinSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            dgvThongTinSanPham.GridColor = Color.FromArgb(231, 229, 255);
            dgvThongTinSanPham.Location = new Point(12, 102);
            dgvThongTinSanPham.Name = "dgvThongTinSanPham";
            dgvThongTinSanPham.RowHeadersVisible = false;
            dgvThongTinSanPham.RowTemplate.Height = 25;
            dgvThongTinSanPham.Size = new Size(489, 290);
            dgvThongTinSanPham.TabIndex = 28;
            dgvThongTinSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvThongTinSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvThongTinSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvThongTinSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvThongTinSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvThongTinSanPham.ThemeStyle.BackColor = Color.White;
            dgvThongTinSanPham.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvThongTinSanPham.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvThongTinSanPham.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvThongTinSanPham.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvThongTinSanPham.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvThongTinSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvThongTinSanPham.ThemeStyle.HeaderStyle.Height = 23;
            dgvThongTinSanPham.ThemeStyle.ReadOnly = false;
            dgvThongTinSanPham.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvThongTinSanPham.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvThongTinSanPham.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvThongTinSanPham.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvThongTinSanPham.ThemeStyle.RowsStyle.Height = 25;
            dgvThongTinSanPham.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvThongTinSanPham.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(12, 395);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(76, 17);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "0 sản phẩm";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // DisplayProductInformation
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(513, 417);
            Controls.Add(lblStatus);
            Controls.Add(dgvThongTinSanPham);
            Controls.Add(lblMaVanDon);
            Controls.Add(btnBack);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayProductInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin sản phẩm của đơn hàng";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Label lblMaVanDon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinSanPham;
        private Label lblStatus;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}