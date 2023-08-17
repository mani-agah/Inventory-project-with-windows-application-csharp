using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anbardari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            MD5 md = MD5.Create();
            byte[] hashedPassword = md.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text));
            string password = Convert.ToBase64String(hashedPassword);

            if (txtPassword.Text != null && txtUserName.Text != null)
            {
                var checkManager = (from a in context.AdminTbls
                                    where a.AdminUserName == txtUserName.Text && a.AdminUserPassword == txtPassword.Text
                                    select a).FirstOrDefault();
                if (checkManager != null)
                {
                    if (checkManager.AdminRull == 2)
                    {
                        OperatorPanel adminpanel = new OperatorPanel(checkManager);
                        adminpanel.ShowDialog();
                    }
                    else if (checkManager.AdminRull == 1)
                    {
                        ManagerPanel manager = new ManagerPanel(checkManager);
                        manager.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("نام کاربری و یا رمز عبور اشتباه است");
                }
            }
            else
            {
                MessageBox.Show("لطفا فیلد هارا پر کنید");
            }
        }
    }
}
