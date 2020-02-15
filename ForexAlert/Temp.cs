using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexAlert
{
    public class Temp
    {
        public static string currency { get; set; }
        public static string loss { get; set; }
        public static string taik { get; set; }
        public static string price { get; set; }

        public Temp(string _currency, string _loss, string _taik, string _price)
        {
            currency = _currency;
            loss = _loss;
            taik = _taik;
            price = _price;
        }
    }
}
