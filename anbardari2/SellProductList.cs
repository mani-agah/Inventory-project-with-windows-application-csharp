using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace anbardari2
{
    public class SellProductList
    {
        public string masoolPakhsh { get; set; }
        public string CsutomerName { get; set; }
        public string number { get; set; }
        public string address { get; set; }
        public double offerPrice { get; set; }
        public List<SellProductList> Productlist(string masoolPakhsh, string name, string number, string add, double offer)
        {
            List<SellProductList> productLists = new List<SellProductList>()
            {
                new SellProductList(){masoolPakhsh = masoolPakhsh,CsutomerName = name,number = number,address = add,offerPrice = offer}
            };
            return productLists;
        }
    }
}
