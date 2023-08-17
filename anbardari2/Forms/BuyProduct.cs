using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anbardari2.Forms
{
    public partial class BuyProduct : Form
    {
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public AdminTbl Admin;
        public BuyProduct(AdminTbl admin)
        {
            InitializeComponent();
            Admin = admin;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BuyProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.ProductTbls.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var checkProduct = (from a in context.ProductTbls
                                where a.ProductId == id
                                select a).FirstOrDefault();
            if (checkProduct != null)
            {
                txtName.Text = checkProduct.ProductName;
                txtProductCode.Text = checkProduct.ProductCode;
                txtPrice.Text = checkProduct.ProductPrice.ToString();
                txtDescription.Text = checkProduct.ProductDescription;
                dateTimePicker1.Value = checkProduct.ProductExpire;
            }
        }
        public List<BuyProductList> buyProducts = new List<BuyProductList>();
        private void button3_Click(object sender, EventArgs e)
        {
            BuyProductList buyList = new BuyProductList();
            var sendData = buyList.Productlist(txtProductCode.Text, Convert.ToInt32(txtNumber.Text),txtName.Text,Convert.ToDouble(txtPrice.Text));
            buyProducts.AddRange(sendData);
            txtNumber.Text = null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            BuyFactor factor = new BuyFactor(buyProducts,Admin);
            factor.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
