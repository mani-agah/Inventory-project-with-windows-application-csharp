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
    public partial class watchSellFactor : Form
    {
        public AdminTbl admintb;
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public watchSellFactor(AdminTbl admin)
        {
            InitializeComponent();
            admintb = admin;
        }

        private void watchSellFactor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.FactorSellTbls.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*var getData = (from a in context.factorsells
                           orderby a.factorSubmitDateTime
                           select a).ToList();
            dataGridView1.DataSource = getData;*/

        }
    }
}
