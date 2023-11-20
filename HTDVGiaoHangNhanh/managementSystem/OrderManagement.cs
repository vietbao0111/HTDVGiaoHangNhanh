using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTDVGiaoHangNhanh.managementSystem
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTTDonHang_Click(object sender, EventArgs e)
        {
            ProductManagement product = new ProductManagement();
            this.Hide();
            product.ShowDialog();
            this.Show();
        }
    }
}
