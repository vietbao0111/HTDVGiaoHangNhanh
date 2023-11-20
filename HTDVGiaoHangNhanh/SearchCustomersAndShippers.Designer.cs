namespace HTDVGiaoHangNhanh
{
    partial class SearchCustomersAndShippers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomersAndShippers));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlTitle = new Panel();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            lblTitle = new Label();
            lblLoaiTimKiem = new Label();
            lblThuocTinh = new Label();
            lblStatus = new Label();
            cboLoaiTimKiem = new Guna.UI2.WinForms.Guna2ComboBox();
            cboThuocTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            dgvTimKiem = new Guna.UI2.WinForms.Guna2DataGridView();
            btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimKiem).BeginInit();
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
            pnlTitle.Size = new Size(867, 40);
            pnlTitle.TabIndex = 5;
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
            btnBack.Location = new Point(12, 67);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(117, 39);
            btnBack.TabIndex = 30;
            btnBack.Text = "Trở về";
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(228, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(411, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Tìm kiếm nhân viên giao hàng và khách hàng";
            // 
            // lblLoaiTimKiem
            // 
            lblLoaiTimKiem.AutoSize = true;
            lblLoaiTimKiem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoaiTimKiem.Location = new Point(212, 77);
            lblLoaiTimKiem.Name = "lblLoaiTimKiem";
            lblLoaiTimKiem.Size = new Size(91, 16);
            lblLoaiTimKiem.TabIndex = 31;
            lblLoaiTimKiem.Text = "Loại tìm kiếm: ";
            // 
            // lblThuocTinh
            // 
            lblThuocTinh.AutoSize = true;
            lblThuocTinh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblThuocTinh.Location = new Point(485, 77);
            lblThuocTinh.Name = "lblThuocTinh";
            lblThuocTinh.Size = new Size(74, 16);
            lblThuocTinh.TabIndex = 32;
            lblThuocTinh.Text = "Thuộc tính: ";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 447);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 13);
            lblStatus.TabIndex = 45;
            lblStatus.Text = "0 đơn hàng";
            // 
            // cboLoaiTimKiem
            // 
            cboLoaiTimKiem.BackColor = Color.Transparent;
            cboLoaiTimKiem.BorderRadius = 3;
            cboLoaiTimKiem.CustomizableEdges = customizableEdges3;
            cboLoaiTimKiem.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoaiTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiTimKiem.FocusedColor = Color.FromArgb(94, 148, 255);
            cboLoaiTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboLoaiTimKiem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboLoaiTimKiem.ForeColor = Color.FromArgb(68, 88, 112);
            cboLoaiTimKiem.FormattingEnabled = true;
            cboLoaiTimKiem.ItemHeight = 30;
            cboLoaiTimKiem.Location = new Point(310, 67);
            cboLoaiTimKiem.Name = "cboLoaiTimKiem";
            cboLoaiTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cboLoaiTimKiem.Size = new Size(169, 36);
            cboLoaiTimKiem.TabIndex = 46;
            // 
            // cboThuocTinh
            // 
            cboThuocTinh.BackColor = Color.Transparent;
            cboThuocTinh.BorderRadius = 3;
            cboThuocTinh.CustomizableEdges = customizableEdges5;
            cboThuocTinh.DrawMode = DrawMode.OwnerDrawFixed;
            cboThuocTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuocTinh.FocusedColor = Color.FromArgb(94, 148, 255);
            cboThuocTinh.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboThuocTinh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboThuocTinh.ForeColor = Color.FromArgb(68, 88, 112);
            cboThuocTinh.FormattingEnabled = true;
            cboThuocTinh.ItemHeight = 30;
            cboThuocTinh.Location = new Point(566, 67);
            cboThuocTinh.Name = "cboThuocTinh";
            cboThuocTinh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboThuocTinh.Size = new Size(166, 36);
            cboThuocTinh.TabIndex = 47;
            // 
            // txtSearch
            // 
            txtSearch.BorderColor = Color.GreenYellow;
            txtSearch.BorderRadius = 3;
            txtSearch.BorderThickness = 2;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.CustomizableEdges = customizableEdges7;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(215, 110);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSearch.Size = new Size(398, 45);
            txtSearch.TabIndex = 48;
            // 
            // dgvTimKiem
            // 
            dgvTimKiem.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTimKiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTimKiem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTimKiem.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTimKiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTimKiem.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTimKiem.GridColor = Color.FromArgb(231, 229, 255);
            dgvTimKiem.Location = new Point(12, 162);
            dgvTimKiem.Name = "dgvTimKiem";
            dgvTimKiem.ReadOnly = true;
            dgvTimKiem.RowHeadersVisible = false;
            dgvTimKiem.RowTemplate.Height = 25;
            dgvTimKiem.Size = new Size(843, 331);
            dgvTimKiem.TabIndex = 49;
            dgvTimKiem.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTimKiem.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTimKiem.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTimKiem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTimKiem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTimKiem.ThemeStyle.BackColor = Color.White;
            dgvTimKiem.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTimKiem.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTimKiem.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTimKiem.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvTimKiem.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTimKiem.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvTimKiem.ThemeStyle.HeaderStyle.Height = 23;
            dgvTimKiem.ThemeStyle.ReadOnly = true;
            dgvTimKiem.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTimKiem.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTimKiem.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvTimKiem.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTimKiem.ThemeStyle.RowsStyle.Height = 25;
            dgvTimKiem.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTimKiem.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnTimKiem
            // 
            btnTimKiem.BorderRadius = 3;
            btnTimKiem.CustomizableEdges = customizableEdges9;
            btnTimKiem.DisabledState.BorderColor = Color.DarkGray;
            btnTimKiem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTimKiem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTimKiem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTimKiem.FillColor = Color.FromArgb(255, 192, 128);
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(738, 67);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnTimKiem.Size = new Size(117, 39);
            btnTimKiem.TabIndex = 50;
            btnTimKiem.Text = "Tìm kiếm";
            // 
            // SearchCustomersAndShippers
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(867, 520);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvTimKiem);
            Controls.Add(txtSearch);
            Controls.Add(cboThuocTinh);
            Controls.Add(cboLoaiTimKiem);
            Controls.Add(lblStatus);
            Controls.Add(lblThuocTinh);
            Controls.Add(lblLoaiTimKiem);
            Controls.Add(btnBack);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchCustomersAndShippers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tìm kiếm";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimKiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Label lblLoaiTimKiem;
        private Label lblThuocTinh;
        private Label lblStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboThuocTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
    }
}