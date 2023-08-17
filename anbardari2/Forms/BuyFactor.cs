using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anbardari2.Forms
{
    public partial class BuyFactor : Form
    {
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public List<BuyProductList> productList = new List<BuyProductList>();
        public AdminTbl Admin;
        public BuyFactor(List<BuyProductList> List, AdminTbl admin)
        {
            InitializeComponent();
            productList.AddRange(List);
            Admin = admin;
        }
        private void BuyFactor_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            FactorTbl factor = new FactorTbl();
            factor.FactorSubmitTime = DateTime.Now;
            factor.FactorCode = rand.Next(1000, 10000).ToString();
            context.FactorTbls.Add(factor);
            context.SaveChanges();
            dataGridView1.DataSource = productList.ToList();
            FactorDetailsTbl selProduct = new FactorDetailsTbl();
            foreach (BuyProductList item in productList)
            {
                var b = item.price += item.allPrice;
                allPrice.Text = $"ریال {b}";
                var c = 0.05 * b;
                labelbarprice.Text = $"ریال {c}";
                allPriceAfterBar.Text = $"ریال {b + c}";
                selProduct.Count = item.number;
                selProduct.Name = item.name;
                selProduct.Price = item.price;
                var getFactorId = (from a in context.FactorTbls
                                   where a.FactorCode == factor.FactorCode
                                   select a.FactorId).FirstOrDefault();
                selProduct.Fk = getFactorId;
                context.FactorDetailsTbls.Add(selProduct);
                context.SaveChanges();
                var GetProduct = (from a in context.ProductTbls
                                  where a.ProductCode == item.code
                                  select a).FirstOrDefault();
                var InventoryAdd = (from a in context.InventoryTbls
                                    where a.ProductCode == item.code
                                    select a).FirstOrDefault();
                InventoryTbl inventory = new InventoryTbl();
                if (InventoryAdd != null)
                {
                    InventoryAdd.ExpireDate = GetProduct.ProductExpire;
                    InventoryAdd.number = item.number + InventoryAdd.number;
                    InventoryAdd.ProductCode = item.code;
                    InventoryAdd.OperatorName = Admin.AdminUserName;
                    InventoryAdd.ProductPrice = item.price;
                    InventoryAdd.SubmitDate = DateTime.Now;
                    context.InventoryTbls.AddOrUpdate(InventoryAdd);
                    context.SaveChanges();
                }
                else
                {
                    inventory.ExpireDate = GetProduct.ProductExpire;
                    inventory.number = item.number;
                    inventory.OperatorName = Admin.AdminUserName;
                    inventory.ProductCode = item.code.ToString();
                    inventory.ProductPrice = item.price;
                    inventory.SubmitDate = DateTime.Now;
                    context.InventoryTbls.Add(inventory);
                    context.SaveChanges();
                }

            }
        }

    }
}
