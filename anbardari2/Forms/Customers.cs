using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anbardari2.Forms
{
    public partial class Customers : Form
    {
        public AdminTbl adm;
        public Customers(AdminTbl admin)
        {
            InitializeComponent();
            adm = admin;
        }
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            var checkNationalCode = (from a in context.CustomerTbls
                                     where a.CustomerNationalCode == txtNationalCode.Text
                                     select a).FirstOrDefault();
            if (checkNationalCode != null)
            {
                try
                {
                    checkNationalCode.CustomerName = txtName.Text;
                    checkNationalCode.CustomerLastName = txtLastName.Text;
                    checkNationalCode.CustomerNumber = txtNumber.Text;
                    checkNationalCode.CustomerFatherName = txtFatherName.Text;
                    checkNationalCode.CustomerAddress = txtAddress.Text;
                    context.CustomerTbls.AddOrUpdate(checkNationalCode);
                    context.SaveChanges();
                    MessageBox.Show("اطلاعات کاربر با موفقیت تغیر کرد");
                    txtName.Text = null;
                    txtNationalCode.Text = null;
                    txtNumber.Text = null;
                    txtLastName.Text = null;
                    txtFatherName.Text = null;
                    txtAddress.Text = null;
                }
                catch
                {
                    MessageBox.Show("خطا در تغیر اطلاعات کاربر!!");
                }
            }
            else
            {
                try
                {
                    CustomerTbl customer = new CustomerTbl();
                    customer.CustomerName = txtName.Text;
                    customer.CustomerLastName = txtLastName.Text;
                    customer.CustomerFatherName = txtFatherName.Text;
                    customer.CustomerNumber = txtNumber.Text;
                    customer.CustomerAddress = txtAddress.Text;
                    customer.CustomerNationalCode = txtNationalCode.Text;
                    context.CustomerTbls.Add(customer);
                    context.SaveChanges();
                    MessageBox.Show("مشتری با موفقیت اضافه شد");
                    customer = null;
                    txtName.Text = null;
                    txtLastName.Text = null;
                    txtFatherName.Text = null;
                    txtNumber.Text = null;
                    txtAddress.Text = null;
                    txtNationalCode.Text = null;
                    dataGridView1.DataSource = context.CustomerTbls.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در ساخت مشتری");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ManagerPanel frm = new ManagerPanel(adm);
            //frm.ShowDialog();
            this.Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.CustomerTbls.ToList();

        }
        public bool check = false;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            check = true;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var findUser = (from a in context.CustomerTbls
                            where a.CustomerId == id
                            select a).FirstOrDefault();
            txtName.Text = findUser.CustomerName;
            txtLastName.Text = findUser.CustomerLastName;
            txtFatherName.Text = findUser.CustomerFatherName;
            txtNationalCode.Text = findUser.CustomerNationalCode;
            txtNumber.Text = findUser.CustomerNumber;
            txtAddress.Text = findUser.CustomerAddress;
            var checkNationalCode = (from a in context.CustomerTbls
                                     where a.CustomerNationalCode == txtNationalCode.Text
                                     select a).FirstOrDefault();
            if (checkNationalCode != null)
            {
                button2.Text = "ویرایش کاربر";
            }

        }
    }
}
