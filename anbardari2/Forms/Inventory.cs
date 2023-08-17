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
    public partial class Inventory : Form
    {
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public AdminTbl Admin;
        public Inventory(AdminTbl admin)
        {
            InitializeComponent();
            Admin = admin;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.InventoryTbls.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var getData = (from a in context.InventoryTbls
                           orderby a.SubmitDate
                           select a).ToList();
            dataGridView1.DataSource = getData;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var getData = (from a in context.InventoryTbls
                           orderby a.ProductPrice
                           select a).ToList();
            dataGridView1.DataSource = getData;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var getData = (from a in context.InventoryTbls
                           orderby a.number
                           select a).ToList();
            dataGridView1.DataSource = getData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Admin.AdminRull == 2)
            {
                OperatorPanel op = new OperatorPanel(Admin);
            }
            else if (Admin.AdminRull == 1)
            {
                ManagerPanel mp = new ManagerPanel(Admin);
                mp.ShowDialog();
            }
        }
    }
}
