namespace HTDVGiaoHangNhanh.statistical
{
    partial class SalaryOfEmployees
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlTitle = new Panel();
            lblTitle = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            lblThangNamHT = new Label();
            pnlTitle.SuspendLayout();
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
            pnlTitle.Size = new Size(1000, 52);
            pnlTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(419, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(163, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Lương nhân viên";
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
            btnBack.Location = new Point(12, 54);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnBack.Size = new Size(117, 39);
            btnBack.TabIndex = 29;
            btnBack.Text = "Trở về";
            // 
            // lblThangNamHT
            // 
            lblThangNamHT.AutoSize = true;
            lblThangNamHT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblThangNamHT.Location = new Point(839, 63);
            lblThangNamHT.Name = "lblThangNamHT";
            lblThangNamHT.Size = new Size(158, 21);
            lblThangNamHT.TabIndex = 30;
            lblThangNamHT.Text = "Tháng 11 năm 2023";
            // 
            // SalaryOfEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(lblThangNamHT);
            Controls.Add(btnBack);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalaryOfEmployees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lương nhân viên";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Label lblThangNamHT;
    }
}