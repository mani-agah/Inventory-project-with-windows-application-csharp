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
    public partial class watchBuyFactor : Form
    {
        public AdminTbl admin;
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public watchBuyFactor(AdminTbl adminTbl)
        {
            InitializeComponent();
            admin = adminTbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerPanel manFrm = new ManagerPanel(admin);
            manFrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var getAllData = (from a in context.FactorTbls
                              orderby a.FactorSubmitTime
                              select a).ToList();
            dataGridView1.DataSource = getAllData;
        }

        private void watchBuyFactor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.FactorTbls.ToList();
        }
    }
}
