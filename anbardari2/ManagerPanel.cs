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
    public partial class ManagerPanel : Form
    {
        public string name;
        public AdminTbl admin;
        public ManagerPanel(AdminTbl manager)
        {
            InitializeComponent();
            name = manager.AdminName;
            admin = manager;
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            labelName.Text = $"{name} خوش آمدید";
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            Customers custom = new Customers(admin);
            custom.ShowDialog();
        }

        private void OperatorBtn_Click(object sender, EventArgs e)
        {
            Operator op = new Operator(admin);
            op.ShowDialog();
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            Products pro = new Products(admin);
            pro.ShowDialog();
        }

        private void BuyProductBtn_Click(object sender, EventArgs e)
        {
            BuyProduct buyPro = new BuyProduct(admin);
            buyPro.ShowDialog();
        }

        private void WatchFactorsBtn_Click(object sender, EventArgs e)
        {
            watchBuyFactor buyFactor = new watchBuyFactor(admin);
            buyFactor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            watchSellFactor sellFactors = new watchSellFactor(admin);
            sellFactors.ShowDialog();
        }

        private void ManageringInventoryBtn_Click(object sender, EventArgs e)
        {
            Inventory iv = new Inventory(admin);
            iv.ShowDialog();
        }

        private void SellProductBtn_Click(object sender, EventArgs e)
        {
            SellProduct selproduct = new SellProduct();
            selproduct.ShowDialog();
        }
    }
}
