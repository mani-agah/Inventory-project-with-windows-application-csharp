using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace anbardari2
{
    public partial class AdminPanel : Form
    {
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public string name;
        public AdminPanel(AdminTbl admin)
        {
            InitializeComponent();
            name = admin;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            labelName.Text = $"{name} خوش آمدید";
        }
    }
}
