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

namespace anbardari2.Forms
{
    public partial class Operator : Form
    {
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public AdminTbl adm;
        public Operator(AdminTbl admin)
        {
            InitializeComponent();
            adm = admin;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Operator_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = context.RullTbls.ToList();
            comboBox1.DisplayMember = "RullName";
            comboBox1.ValueMember = "RullId";
            var admin = from a in context.AdminTbls
                        join b in context.RullTbls on a.AdminRull equals b.RullId
                        select new { a.AdminId, a.AdminName, a.AdminUserName, b.RullName, a.AdminUserPassword };
            dataGridView1.DataSource = admin.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var checkUser = (from a in context.AdminTbls
                             where a.AdminUserName == txtUserName.Text && a.AdminUserPassword == txtFirstPassword.Text
                             select a).FirstOrDefault();
            if (checkUser != null)
            {
                checkUser.AdminRull = (int)comboBox1.SelectedValue;
                checkUser.AdminName = txtName.Text;
                checkUser.AdminUserName = txtUserName.Text;
                checkUser.AdminUserPassword = txtFirstPassword.Text;
                context.AdminTbls.AddOrUpdate(checkUser);
            }
            else
            {
                AdminTbl admin = new AdminTbl();
                if (txtFirstPassword.Text == txtSeccondPassword.Text)
                {
                    var checkUserName = (from a in context.AdminTbls
                                         where a.AdminUserName == txtUserName.Text
                                         select a).FirstOrDefault();
                    if (checkUserName == null)
                    {
                        try
                        {
                            admin.AdminName = txtName.Text;
                            admin.AdminUserName = txtUserName.Text;
                            admin.AdminUserPassword = txtFirstPassword.Text;
                            admin.AdminRull = (int)comboBox1.SelectedValue;
                            context.AdminTbls.Add(admin);
                            context.SaveChanges();
                            admin = null;
                            MessageBox.Show("ادمین با موفقیت اضافه شد");
                            txtName.Text = null;
                            txtUserName.Text = null;
                            txtSeccondPassword.Text = null;
                            txtFirstPassword.Text = null;
                        }
                        catch
                        {
                            MessageBox.Show("اضافه کردن ادمین با موفقیت اضافه شد");
                        }
                    }
                    else
                    {
                        MessageBox.Show("این نام کاربری توسط کاربر دیگه ای انتخاب شده است");
                    }
                }
                else
                {
                    MessageBox.Show("پسوورد ها یکسان نیستند");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerPanel mangerFrm = new ManagerPanel(adm);
            mangerFrm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var Check = (from a in context.AdminTbls
                         where a.AdminId == id
                         select a).FirstOrDefault();
            if (Check != null)
            {
                txtName.Text = Check.AdminName;
                txtUserName.Text = Check.AdminUserName;
                txtFirstPassword.Text = Check.AdminUserPassword;
                txtSeccondPassword.Text = Check.AdminUserPassword;
                comboBox1.SelectedValue = Check.AdminRull;
                button2.Text = "ویرایش ادمین";
            }
        }
    }
}