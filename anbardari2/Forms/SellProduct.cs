using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anbardari2.Forms
{
    public partial class SellProduct : Form
    {
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public SellProduct()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells[0].Value;
            var getCustomer = (from a in context.CustomerTbls
                               where a.CustomerId == id
                               select a).FirstOrDefault();
            txtName.Text = getCustomer.CustomerName;
            txtFatherName.Text = getCustomer.CustomerFatherName;
            txtLastName.Text = getCustomer.CustomerLastName;
            txtNationalCode.Text = getCustomer.CustomerNationalCode;
            txtPhone.Text = getCustomer.CustomerNumber;
            txtAddress.Text = getCustomer.CustomerAddress;
        }

        private void SellProduct_Load(object sender, EventArgs e)
        {
            var checkProductInventory = (from a in context.InventoryTbls
                                         join b in context.ProductTbls on a.ProductCode equals b.ProductCode
                                         select new { b.ProductId, b.ProductName }).ToList();
            dataGridView1.DataSource = checkProductInventory;
            dataGridView2.DataSource = context.CustomerTbls.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var getProduct = (from a in context.ProductTbls
                              where a.ProductId == id
                              select a).FirstOrDefault();
            txtDesc.Text = getProduct.ProductDescription;
            txtProductName.Text = getProduct.ProductName;
            txtPrice.Text = getProduct.ProductPrice.ToString();
            txtProductCode.Text = getProduct.ProductCode;
            dateTimePicker1.Value = getProduct.ProductExpire;

        }
        public List<ProductListS> productSells = new List<ProductListS>();
        public CustomerTbl customer;
        private void button3_Click(object sender, EventArgs e)
        {
            int idProduct = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var getProduct = (from a in context.ProductTbls
                              where a.ProductId == idProduct
                              select a).FirstOrDefault();
            int id = (int)dataGridView2.CurrentRow.Cells[0].Value;
            var getCustomer = (from a in context.CustomerTbls
                               where a.CustomerId == id
                               select a).FirstOrDefault();
            double c = getProduct.ProductPrice + (getProduct.ProductPrice * 0.07);
           List<ProductListS> s = new List<ProductListS>()
            {
                new ProductListS(){masoolPakhsh = txtMasoolPakhsh.Text,ProductCount = Convert.ToInt32(txtNumber.Text),ProductName = getProduct.ProductName,ProductOffer = Convert.ToDouble(txtOff.Text),ProductPrice=c}
            };
            productSells.AddRange(s);
            customer = getCustomer;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SellFactor self = new SellFactor(productSells,customer);
            self.ShowDialog();
        }
    }
}
