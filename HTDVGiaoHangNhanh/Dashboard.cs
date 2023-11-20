using HTDVGiaoHangNhanh.managementSystem;
using HTDVGiaoHangNhanh.personalInformation;
using HTDVGiaoHangNhanh.printer;
using HTDVGiaoHangNhanh.statistical;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HTDVGiaoHangNhanh
{
    public partial class Dashboard : Form
    {
        public Dashboard(string username, string displayName, string access)
        {
            InitializeComponent();
            Username = username;
            DisplayName = displayName;
            Access = access;

        }
        private string Username { get; set; }
        private string DisplayName { get; set; }
        private string Access { get; set; }

        private void iNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void đổiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword();
            this.Hide();
            password.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.ShowDialog();

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement account = new AccountManagement();
            this.Hide();
            account.ShowDialog();
            this.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderManagement order = new OrderManagement();
            this.Hide();
            order.ShowDialog();
            this.Show();
        }

        private void nhânViênGiaoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipperManagement shipper = new ShipperManagement();
            this.Hide();
            shipper.ShowDialog();
            this.Show();
        }

        private void btnThongTinSanPham_Click(object sender, EventArgs e)
        {
            DisplayProductInformation dpi = new DisplayProductInformation();
            this.Hide();
            dpi.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManagement customer = new CustomerManagement();
            this.Hide();
            customer.ShowDialog();
            this.Show();
        }

        private void đơnHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderStatistics orderStatistics = new OrderStatistics();
            this.Hide();
            orderStatistics.ShowDialog();
            this.Show();
        }

        private void tổngĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalRevenueStatistics totalRevenue = new TotalRevenueStatistics();
            this.Hide();
            totalRevenue.ShowDialog();
            this.Show();
        }

        private void sốLượngĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsOfTheNumberOfOrders statistics = new StatisticsOfTheNumberOfOrders();
            this.Hide();
            statistics.ShowDialog();
            this.Show();
        }

        private void phiếuGiaoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDonHang donHang = new ShowDonHang();
            this.Hide();
            donHang.ShowDialog();
            this.Show();
        }

        private void đổiTênHiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDisplayName displayName = new ChangeDisplayName();
            this.Hide();
            displayName.ShowDialog();
            this.Show();
        }

        private void đơnHàngĐảmNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryOfPersonal salary = new SalaryOfPersonal();
            this.Hide();
            salary.ShowDialog();
            this.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCustomersAndShippers search = new SearchCustomersAndShippers();
            this.Hide();
            search.ShowDialog();
            this.Show();
        }
    }
}
