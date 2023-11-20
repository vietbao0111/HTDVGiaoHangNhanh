namespace HTDVGiaoHangNhanh.managementSystem
{
    partial class AccountManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlTitle = new Panel();
            lblTitle = new Label();
            dgvAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            lblStatus = new Label();
            lblUsername = new Label();
            lblDisplayName = new Label();
            lblAccess = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtDisplayName = new Guna.UI2.WinForms.Guna2TextBox();
            cboAccess = new Guna.UI2.WinForms.Guna2ComboBox();
            btnNewAdd = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
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
            pnlTitle.Size = new Size(800, 46);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(266, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(269, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Quản lý tài khoản đăng nhập";
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAccount.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAccount.GridColor = Color.FromArgb(231, 229, 255);
            dgvAccount.Location = new Point(12, 58);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersVisible = false;
            dgvAccount.RowTemplate.Height = 25;
            dgvAccount.Size = new Size(455, 355);
            dgvAccount.TabIndex = 9;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAccount.ThemeStyle.BackColor = Color.White;
            dgvAccount.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAccount.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAccount.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAccount.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvAccount.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAccount.ThemeStyle.HeaderStyle.Height = 23;
            dgvAccount.ThemeStyle.ReadOnly = true;
            dgvAccount.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAccount.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAccount.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvAccount.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvAccount.ThemeStyle.RowsStyle.Height = 25;
            dgvAccount.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAccount.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(9, 416);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 13);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "0 tài khoản";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(480, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(104, 16);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Tên đăng nhập: ";
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayName.Location = new Point(480, 112);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(81, 16);
            lblDisplayName.TabIndex = 11;
            lblDisplayName.Text = "Tên hiển thị: ";
            // 
            // lblAccess
            // 
            lblAccess.AutoSize = true;
            lblAccess.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccess.Location = new Point(480, 155);
            lblAccess.Name = "lblAccess";
            lblAccess.Size = new Size(102, 16);
            lblAccess.TabIndex = 13;
            lblAccess.Text = "Quyền truy cập: ";
            // 
            // txtUsername
            // 
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(588, 58);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(200, 36);
            txtUsername.TabIndex = 14;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Cursor = Cursors.IBeam;
            txtDisplayName.CustomizableEdges = customizableEdges3;
            txtDisplayName.DefaultText = "";
            txtDisplayName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDisplayName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDisplayName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDisplayName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDisplayName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDisplayName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplayName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDisplayName.Location = new Point(588, 100);
            txtDisplayName.Margin = new Padding(4);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.PasswordChar = '\0';
            txtDisplayName.PlaceholderText = "";
            txtDisplayName.SelectedText = "";
            txtDisplayName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDisplayName.Size = new Size(200, 36);
            txtDisplayName.TabIndex = 15;
            // 
            // cboAccess
            // 
            cboAccess.BackColor = Color.Transparent;
            cboAccess.BorderRadius = 3;
            cboAccess.CustomizableEdges = customizableEdges5;
            cboAccess.DrawMode = DrawMode.OwnerDrawFixed;
            cboAccess.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAccess.FocusedColor = Color.FromArgb(94, 148, 255);
            cboAccess.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboAccess.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboAccess.ForeColor = Color.FromArgb(68, 88, 112);
            cboAccess.FormattingEnabled = true;
            cboAccess.ItemHeight = 30;
            cboAccess.Location = new Point(588, 143);
            cboAccess.Name = "cboAccess";
            cboAccess.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboAccess.Size = new Size(200, 36);
            cboAccess.TabIndex = 16;
            // 
            // btnNewAdd
            // 
            btnNewAdd.BorderRadius = 3;
            btnNewAdd.CustomizableEdges = customizableEdges7;
            btnNewAdd.DisabledState.BorderColor = Color.DarkGray;
            btnNewAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNewAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNewAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNewAdd.FillColor = Color.FromArgb(192, 0, 192);
            btnNewAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewAdd.ForeColor = Color.White;
            btnNewAdd.Location = new Point(578, 305);
            btnNewAdd.Margin = new Padding(3, 4, 3, 4);
            btnNewAdd.Name = "btnNewAdd";
            btnNewAdd.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNewAdd.Size = new Size(117, 39);
            btnNewAdd.TabIndex = 17;
            btnNewAdd.Text = "Tạo mới";
            // 
            // btnThem
            // 
            btnThem.BorderRadius = 3;
            btnThem.CustomizableEdges = customizableEdges9;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(517, 352);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnThem.Size = new Size(117, 39);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            // 
            // btnCapNhat
            // 
            btnCapNhat.BorderRadius = 3;
            btnCapNhat.CustomizableEdges = customizableEdges11;
            btnCapNhat.DisabledState.BorderColor = Color.DarkGray;
            btnCapNhat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCapNhat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCapNhat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCapNhat.FillColor = Color.Lime;
            btnCapNhat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(640, 352);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCapNhat.Size = new Size(117, 39);
            btnCapNhat.TabIndex = 19;
            btnCapNhat.Text = "Cập nhật";
            // 
            // btnXoa
            // 
            btnXoa.BorderRadius = 3;
            btnXoa.CustomizableEdges = customizableEdges13;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(517, 398);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnXoa.Size = new Size(117, 39);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 3;
            btnBack.CustomizableEdges = customizableEdges15;
            btnBack.DialogResult = DialogResult.Cancel;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.Gold;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(640, 398);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnBack.Size = new Size(117, 39);
            btnBack.TabIndex = 21;
            btnBack.Text = "Trở về";
            btnBack.Click += btnBack_Click;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(btnNewAdd);
            Controls.Add(cboAccess);
            Controls.Add(txtDisplayName);
            Controls.Add(txtUsername);
            Controls.Add(lblAccess);
            Controls.Add(lblDisplayName);
            Controls.Add(lblUsername);
            Controls.Add(lblStatus);
            Controls.Add(dgvAccount);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountManagement";
            Load += AccountManagement_Load_1;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAccount;
        private Label lblTitle;
        private Label lblStatus;
        private Label lblUsername;
        private Label lblDisplayName;
        private Label lblAccess;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtDisplayName;
        private Guna.UI2.WinForms.Guna2ComboBox cboAccess;
        private Guna.UI2.WinForms.Guna2Button btnNewAdd;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}