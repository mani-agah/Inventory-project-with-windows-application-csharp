using anbardari2.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anbardari2
{
    public class BuyProductList
    {
        public int number { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public double allPrice { get; set; }

        public List<BuyProductList> Productlist(string co, int num, string na, double pr)
        {
            List<BuyProductList> products = new List<BuyProductList>()
            {

                new BuyProductList() {code= co, number =num,name = na,price = pr,allPrice = pr * num}
            };
            return products;
        }

    }
}
