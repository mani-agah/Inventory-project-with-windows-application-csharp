using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace anbardari2.Forms
{
    public partial class Products : Form
    {
        public AdminTbl Admin;
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public Products(AdminTbl admin)
        {
            InitializeComponent();
            Admin = admin;
        }
        private void Products_Load(object sender, EventArgs e)
        {
            Random rando = new Random();
            txtProductCode.Text = rando.Next(1000, 9999).ToString();
            dataGridView1.DataSource = context.ProductTbls.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var checkProduct = (from a in context.ProductTbls
                                where txtProductCode.Text == a.ProductCode
                                select a).FirstOrDefault();
            Random rando = new Random();
            if (checkProduct != null)
            {
                checkProduct.ProductDescription = txtDescription.Text;
                checkProduct.ProductPrice = Convert.ToDouble(txtPrice.Text);
                checkProduct.ProductExpire = dateTimePicker1.Value;
                checkProduct.ProductName = txtName.Text;
                checkProduct.ProductCode = txtProductCode.Text;
                context.ProductTbls.AddOrUpdate(checkProduct);
                context.SaveChanges();
                MessageBox.Show("کالا با موفقیت ویرایش شد");
                txtProductCode.Text = rando.Next(1000, 9999).ToString();
                txtDescription.Text = null;
                txtPrice.Text = null;
                dateTimePicker1.Value = DateTime.Now;
                txtName.Text = null;
                dataGridView1.DataSource = context.ProductTbls.ToList();
            }
            else
            {
                if (txtPrice.Text != null && txtProductCode.Text != null && txtName.Text != null && txtDescription.Text != null)
                {
                    try
                    {
                        ProductTbl product = new ProductTbl();
                        product.ProductName = txtName.Text;
                        product.ProductDescription = txtDescription.Text;
                        product.ProductPrice = Convert.ToDouble(txtPrice.Text);
                        product.ProductExpire = dateTimePicker1.Value;
                        product.ProductCode = txtProductCode.Text;
                        context.ProductTbls.Add(product);
                        context.SaveChanges();
                        MessageBox.Show("کالا با موفقیت اضافه شد");
                        txtName.Text = null;
                        txtDescription.Text = null;
                        txtProductCode.Text = rando.Next(1000, 9999).ToString();
                        txtPrice.Text = null;
                        dateTimePicker1.Value = DateTime.Now;
                        dataGridView1.DataSource = context.ProductTbls.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("اضافه کردن کالا با مشکل مواجه شد");
                    }
                }
                else
                {
                    MessageBox.Show("لطفا همه ی فیلد هارا پر کنید");
                }
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var checkUser = (from a in context.ProductTbls
                             where a.ProductId == id
                             select a).FirstOrDefault();
            if (checkUser != null)
            {
                txtProductCode.Text = null;
                txtDescription.Text = checkUser.ProductDescription;
                txtName.Text = checkUser.ProductName;
                txtPrice.Text = checkUser.ProductPrice.ToString();
                txtProductCode.Text = checkUser.ProductCode;
                dateTimePicker1.Value = checkUser.ProductExpire;
                button2.Text = "ویرایش کالا";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerPanel manager = new ManagerPanel(Admin);
            manager.ShowDialog();
        }
    }
}
