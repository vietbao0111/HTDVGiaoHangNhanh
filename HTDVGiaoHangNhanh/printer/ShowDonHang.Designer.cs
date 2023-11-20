namespace HTDVGiaoHangNhanh.printer
{
    partial class ShowDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDonHang));
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
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnInDH = new Guna.UI2.WinForms.Guna2Button();
            dgvDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlTitle.SuspendLayout();
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
            pnlTitle.Size = new Size(741, 46);
            pnlTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(285, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(179, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "In phiếu giao hàng";
            // 
            // txtSearch
            // 
            txtSearch.BorderColor = Color.GreenYellow;
            txtSearch.BorderRadius = 3;
            txtSearch.BorderThickness = 2;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Black;
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(267, 54);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(206, 45);
            txtSearch.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.CustomizableEdges = customizableEdges3;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.Transparent;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(479, 54);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRefresh.Size = new Size(45, 45);
            btnRefresh.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 3;
            btnBack.CustomizableEdges = customizableEdges5;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.Gold;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 58);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnBack.Size = new Size(117, 39);
            btnBack.TabIndex = 27;
            btnBack.Text = "Trở về";
            // 
            // btnInDH
            // 
            btnInDH.BorderRadius = 3;
            btnInDH.CustomizableEdges = customizableEdges7;
            btnInDH.DialogResult = DialogResult.Cancel;
            btnInDH.DisabledState.BorderColor = Color.DarkGray;
            btnInDH.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInDH.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInDH.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInDH.FillColor = Color.Lime;
            btnInDH.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInDH.ForeColor = Color.White;
            btnInDH.Location = new Point(612, 58);
            btnInDH.Margin = new Padding(3, 4, 3, 4);
            btnInDH.Name = "btnInDH";
            btnInDH.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnInDH.Size = new Size(117, 39);
            btnInDH.TabIndex = 28;
            btnInDH.Text = "In";
            // 
            // dgvDonHang
            // 
            dgvDonHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dgvDonHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDonHang.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDonHang.GridColor = Color.FromArgb(231, 229, 255);
            dgvDonHang.Location = new Point(12, 107);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.ReadOnly = true;
            dgvDonHang.RowHeadersVisible = false;
            dgvDonHang.RowTemplate.Height = 25;
            dgvDonHang.Size = new Size(717, 360);
            dgvDonHang.TabIndex = 29;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDonHang.ThemeStyle.BackColor = Color.White;
            dgvDonHang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDonHang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDonHang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDonHang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDonHang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDonHang.ThemeStyle.HeaderStyle.Height = 23;
            dgvDonHang.ThemeStyle.ReadOnly = true;
            dgvDonHang.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDonHang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDonHang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDonHang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDonHang.ThemeStyle.RowsStyle.Height = 25;
            dgvDonHang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDonHang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ShowDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(741, 480);
            Controls.Add(dgvDonHang);
            Controls.Add(btnInDH);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "In thông tin của đơn hàng";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnInDH;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonHang;
    }
}