using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anbardari2.Forms
{
    public partial class SellFactor : Form
    {
        AgainOstaniDbEntities context = new AgainOstaniDbEntities();
        public List<ProductListS> product = new List<ProductListS>();
        public CustomerTbl customer;
        public SellFactor(List<ProductListS> products, CustomerTbl cust)
        {
            product = products;
            customer = cust;
            InitializeComponent();

        }
        private void SellFactor_Load(object sender, EventArgs e)
        {
            sellFactorTbl selfactorAll = new sellFactorTbl();
            FactorProductSellListTbl list = new FactorProductSellListTbl();
            FactorSellTbl factorsell = new FactorSellTbl();
            factorsell.FactorSubmitTime = DateTime.Now;
            Random rand = new Random();
            factorsell.FactorSellCode = rand.Next(1000, 10000).ToString();
            context.FactorSellTbls.Add(factorsell);
            context.SaveChanges();
            var getFactorSell = (from a in context.FactorSellTbls
                                 where a.FactorSellCode == factorsell.FactorSellCode
                                 select a).FirstOrDefault();
            selfactorAll.factorFk = getFactorSell.FactorSellId;
            selfactorAll.CustomerNumber = customer.CustomerNumber;
            selfactorAll.CustomerAddress = customer.CustomerAddress;
            selfactorAll.CustomerName = customer.CustomerName;
            double allPricee = 0;
            double affer = 0;
            foreach (var item in product)
            {
                allPricee += item.ProductPrice * item.ProductCount;
                selfactorAll.offer = item.ProductOffer;
                selfactorAll.masoolPakhsh = item.masoolPakhsh;
                affer += item.ProductOffer;
            }
            offer.Text = affer.ToString();
            allPrice.Text = allPricee.ToString();
            double check = (allPricee) - (affer * 100);
            allPriceAfterBar.Text = check.ToString();
            context.sellFactorTbls.Add(selfactorAll);
            context.SaveChanges();
            var getCustomer = (from a in context.sellFactorTbls
                               where a.CustomerName == selfactorAll.CustomerName
                               select a).FirstOrDefault();
            foreach (var item in product)
            {
                list.name = item.ProductName;
                list.price = item.ProductPrice;
                list.count = item.ProductCount;
                list.fk = getCustomer.FactorId;
                context.FactorProductSellListTbls.Add(list);
                context.SaveChanges();
            }
            InventoryTbl inven = new InventoryTbl();
            foreach (var item in product)
            {
                var checkProduct = (from a in context.ProductTbls
                                    where a.ProductName == item.ProductName
                                    select a).FirstOrDefault();
                var min = (from a in context.InventoryTbls
                           where a.ProductCode == checkProduct.ProductCode
                           select a).FirstOrDefault();
                min.number = min.number - item.ProductCount;
                context.InventoryTbls.AddOrUpdate(min);
                context.SaveChanges();
            }
            dataGridView1.DataSource = product;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
