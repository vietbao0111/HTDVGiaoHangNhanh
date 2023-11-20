namespace HTDVGiaoHangNhanh.personalInformation
{
    partial class SalaryOfPersonal
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
            pnlTitle = new Panel();
            lblTitle = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            grbLuuY = new GroupBox();
            pnl0DonHang = new Panel();
            panel1 = new Panel();
            pnlThanhCong = new Panel();
            pnlThatBai = new Panel();
            lbl0DonHang = new Label();
            lblThanhCong = new Label();
            lblThatBai = new Label();
            lblThangNamHT = new Label();
            btnPrev = new Guna.UI2.WinForms.Guna2Button();
            btnNext = new Guna.UI2.WinForms.Guna2Button();
            fpnlThu = new FlowLayoutPanel();
            lblThu2 = new Label();
            lblThu3 = new Label();
            lblThu4 = new Label();
            lblThu5 = new Label();
            lblThu6 = new Label();
            lblThu7 = new Label();
            lblChuNhat = new Label();
            fpnlCalendar = new FlowLayoutPanel();
            pnlTitle.SuspendLayout();
            grbLuuY.SuspendLayout();
            fpnlThu.SuspendLayout();
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
            pnlTitle.Size = new Size(770, 46);
            pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(255, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Thống kê đơn hàng cá nhân";
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
            btnBack.Location = new Point(12, 54);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.Size = new Size(117, 39);
            btnBack.TabIndex = 28;
            btnBack.Text = "Trở về";
            btnBack.Click += btnBack_Click;
            // 
            // grbLuuY
            // 
            grbLuuY.Controls.Add(lblThatBai);
            grbLuuY.Controls.Add(lblThanhCong);
            grbLuuY.Controls.Add(lbl0DonHang);
            grbLuuY.Controls.Add(pnlThatBai);
            grbLuuY.Controls.Add(pnlThanhCong);
            grbLuuY.Controls.Add(panel1);
            grbLuuY.Controls.Add(pnl0DonHang);
            grbLuuY.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            grbLuuY.Location = new Point(242, 53);
            grbLuuY.Name = "grbLuuY";
            grbLuuY.Size = new Size(286, 100);
            grbLuuY.TabIndex = 29;
            grbLuuY.TabStop = false;
            grbLuuY.Text = "Lưu ý";
            grbLuuY.Enter += grbLuuY_Enter;
            // 
            // pnl0DonHang
            // 
            pnl0DonHang.BorderStyle = BorderStyle.FixedSingle;
            pnl0DonHang.Location = new Point(26, 24);
            pnl0DonHang.Name = "pnl0DonHang";
            pnl0DonHang.Size = new Size(30, 20);
            pnl0DonHang.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(26, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 20);
            panel1.TabIndex = 30;
            // 
            // pnlThanhCong
            // 
            pnlThanhCong.BackColor = Color.Blue;
            pnlThanhCong.BorderStyle = BorderStyle.FixedSingle;
            pnlThanhCong.Location = new Point(26, 50);
            pnlThanhCong.Name = "pnlThanhCong";
            pnlThanhCong.Size = new Size(30, 20);
            pnlThanhCong.TabIndex = 30;
            // 
            // pnlThatBai
            // 
            pnlThatBai.BackColor = Color.Red;
            pnlThatBai.BorderStyle = BorderStyle.FixedSingle;
            pnlThatBai.Location = new Point(26, 76);
            pnlThatBai.Name = "pnlThatBai";
            pnlThatBai.Size = new Size(30, 20);
            pnlThatBai.TabIndex = 31;
            // 
            // lbl0DonHang
            // 
            lbl0DonHang.AutoSize = true;
            lbl0DonHang.Location = new Point(62, 26);
            lbl0DonHang.Name = "lbl0DonHang";
            lbl0DonHang.Size = new Size(138, 17);
            lbl0DonHang.TabIndex = 32;
            lbl0DonHang.Text = "Chưa nhận đơn hàng";
            lbl0DonHang.Click += lbl0DonHang_Click;
            // 
            // lblThanhCong
            // 
            lblThanhCong.AutoSize = true;
            lblThanhCong.Location = new Point(62, 52);
            lblThanhCong.Name = "lblThanhCong";
            lblThanhCong.Size = new Size(81, 17);
            lblThanhCong.TabIndex = 33;
            lblThanhCong.Text = "Thành công";
            // 
            // lblThatBai
            // 
            lblThatBai.AutoSize = true;
            lblThatBai.Location = new Point(62, 78);
            lblThatBai.Name = "lblThatBai";
            lblThatBai.Size = new Size(129, 17);
            lblThatBai.TabIndex = 34;
            lblThatBai.Text = "Không có đơn hàng";
            // 
            // lblThangNamHT
            // 
            lblThangNamHT.AutoSize = true;
            lblThangNamHT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblThangNamHT.Location = new Point(588, 69);
            lblThangNamHT.Name = "lblThangNamHT";
            lblThangNamHT.Size = new Size(158, 21);
            lblThangNamHT.TabIndex = 30;
            lblThangNamHT.Text = "Tháng 11 năm 2023";
            // 
            // btnPrev
            // 
            btnPrev.CustomizableEdges = customizableEdges3;
            btnPrev.DisabledState.BorderColor = Color.DarkGray;
            btnPrev.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrev.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrev.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrev.FillColor = Color.GreenYellow;
            btnPrev.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(588, 93);
            btnPrev.Name = "btnPrev";
            btnPrev.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPrev.Size = new Size(65, 30);
            btnPrev.TabIndex = 31;
            btnPrev.Text = "Trước";
            // 
            // btnNext
            // 
            btnNext.CustomizableEdges = customizableEdges5;
            btnNext.DisabledState.BorderColor = Color.DarkGray;
            btnNext.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNext.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNext.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNext.FillColor = Color.GreenYellow;
            btnNext.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(681, 93);
            btnNext.Name = "btnNext";
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnNext.Size = new Size(65, 30);
            btnNext.TabIndex = 32;
            btnNext.Text = "Sau";
            // 
            // fpnlThu
            // 
            fpnlThu.Controls.Add(lblThu2);
            fpnlThu.Controls.Add(lblThu3);
            fpnlThu.Controls.Add(lblThu4);
            fpnlThu.Controls.Add(lblThu5);
            fpnlThu.Controls.Add(lblThu6);
            fpnlThu.Controls.Add(lblThu7);
            fpnlThu.Controls.Add(lblChuNhat);
            fpnlThu.Location = new Point(0, 167);
            fpnlThu.Name = "fpnlThu";
            fpnlThu.Size = new Size(770, 30);
            fpnlThu.TabIndex = 33;
            // 
            // lblThu2
            // 
            lblThu2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblThu2.ForeColor = Color.Coral;
            lblThu2.Location = new Point(3, 0);
            lblThu2.Name = "lblThu2";
            lblThu2.Size = new Size(100, 30);
            lblThu2.TabIndex = 1;
            lblThu2.Text = "Thứ hai";
            lblThu2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThu3
            // 
            lblThu3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblThu3.ForeColor = Color.Coral;
            lblThu3.Location = new Point(109, 0);
            lblThu3.Name = "lblThu3";
            lblThu3.Size = new Size(100, 30);
            lblThu3.TabIndex = 2;
            lblThu3.Text = "Thứ ba";
            lblThu3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThu4
            // 
            lblThu4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblThu4.ForeColor = Color.Coral;
            lblThu4.Location = new Point(215, 0);
            lblThu4.Name = "lblThu4";
            lblThu4.Size = new Size(100, 30);
            lblThu4.TabIndex = 3;
            lblThu4.Text = "Thứ tư";
            lblThu4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThu5
            // 
            lblThu5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblThu5.ForeColor = Color.Coral;
            lblThu5.Location = new Point(321, 0);
            lblThu5.Name = "lblThu5";
            lblThu5.Size = new Size(100, 30);
            lblThu5.TabIndex = 4;
            lblThu5.Text = "Thứ năm";
            lblThu5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThu6
            // 
            lblThu6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblThu6.ForeColor = Color.Coral;
            lblThu6.Location = new Point(427, 0);
            lblThu6.Name = "lblThu6";
            lblThu6.Size = new Size(100, 30);
            lblThu6.TabIndex = 5;
            lblThu6.Text = "Thứ sáu";
            lblThu6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThu7
            // 
            lblThu7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblThu7.ForeColor = Color.Coral;
            lblThu7.Location = new Point(533, 0);
            lblThu7.Name = "lblThu7";
            lblThu7.Size = new Size(100, 30);
            lblThu7.TabIndex = 6;
            lblThu7.Text = "Thứ bảy";
            lblThu7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChuNhat
            // 
            lblChuNhat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblChuNhat.ForeColor = Color.Coral;
            lblChuNhat.Location = new Point(639, 0);
            lblChuNhat.Name = "lblChuNhat";
            lblChuNhat.Size = new Size(100, 30);
            lblChuNhat.TabIndex = 7;
            lblChuNhat.Text = "Chủ nhật";
            lblChuNhat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fpnlCalendar
            // 
            fpnlCalendar.AutoScroll = true;
            fpnlCalendar.Dock = DockStyle.Bottom;
            fpnlCalendar.Location = new Point(0, 204);
            fpnlCalendar.Margin = new Padding(3, 4, 3, 4);
            fpnlCalendar.Name = "fpnlCalendar";
            fpnlCalendar.Size = new Size(770, 396);
            fpnlCalendar.TabIndex = 34;
            // 
            // SalaryOfPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(770, 600);
            Controls.Add(fpnlCalendar);
            Controls.Add(fpnlThu);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(lblThangNamHT);
            Controls.Add(grbLuuY);
            Controls.Add(btnBack);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalaryOfPersonal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê đơn hàng cá nhân";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            grbLuuY.ResumeLayout(false);
            grbLuuY.PerformLayout();
            fpnlThu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private GroupBox grbLuuY;
        private Panel pnlThanhCong;
        private Panel panel1;
        private Panel pnl0DonHang;
        private Label lbl0DonHang;
        private Panel pnlThatBai;
        private Label lblThatBai;
        private Label lblThanhCong;
        private Label lblThangNamHT;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private FlowLayoutPanel fpnlThu;
        private Label lblThu2;
        private Label lblThu3;
        private Label lblThu4;
        private Label lblThu5;
        private Label lblThu6;
        private Label lblThu7;
        private Label lblChuNhat;
        private FlowLayoutPanel fpnlCalendar;
    }
}