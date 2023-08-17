using anbardari2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anbardari2
{
    public partial class OperatorPanel : Form
    {
        public AdminTbl Admin;
        public OperatorPanel(AdminTbl admin)
        {
            InitializeComponent();
            Admin = admin;
        }

        private void OperatorPanel_Load(object sender, EventArgs e)
        {
            labelName.Text = $"خوش آمدید {Admin.AdminName}";
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers(Admin);
            customer.ShowDialog();
        }

        private void BuyProductBtn_Click(object sender, EventArgs e)
        {
            BuyProduct product = new BuyProduct(Admin);
            product.ShowDialog();
        }

        private void SellProductBtn_Click(object sender, EventArgs e)
        {
            SellProduct selproduct = new SellProduct();
            selproduct.ShowDialog();
        }

        private void ManageringInventoryBtn_Click(object sender, EventArgs e)
        {
            Inventory inventor = new Inventory(Admin);
            inventor.ShowDialog();
        }
    }
}
