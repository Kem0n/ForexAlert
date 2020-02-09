using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForexAlert
{
    public partial class Form1 : Form
    {
        View view;
        public Form1()
        {
            InitializeComponent();
            view = new View();
            getCurrency();
            //getPrice("EUR/JPY");
        }

        public void getCurrency()
        {
            List<string> listCurrency = new List<string>();
            listCurrency.Add("USD/CHF");
            listCurrency.Add("GBP/USD");
            listCurrency.Add("EUR/USD");
            listCurrency.Add("USD/JPY");
            listCurrency.Add("USD/CAD");
            listCurrency.Add("AUD/USD");
            listCurrency.Add("EUR/GBP");
            listCurrency.Add("EUR/CHF");
            //listCurrency.Add("EUR/JPY");
            //listCurrency.Add("GBP/CHF");
            //listCurrency.Add("CAD/JPY");
            //listCurrency.Add("GBP/JPY");
            //listCurrency.Add("AUD/NZD");
            //listCurrency.Add("AUD/CAD");
            //listCurrency.Add("AUD/CHF");
            //listCurrency.Add("AUD/JPY");
            //listCurrency.Add("CHF/JPY");
            //listCurrency.Add("EUR/NZD");
            //listCurrency.Add("EUR/CAD");
            //listCurrency.Add("CAD/CHF");
            //listCurrency.Add("NZD/JPY");
            //listCurrency.Add("NZD/USD");

            string para = "";

            foreach (var item in listCurrency)
            {
                para += para + "," + item;
            }

            getPrice(para);
            //int x = 0;
            //string price;

            //foreach (string item in listCurrency)
            //{
            //    switch (x)
            //    {
            //        case 1:
            //            label1.Text = String.Format("{0} - {1}",item,price);
            //            break;
            //        case 2:
            //            label2.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 3:
            //            label3.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 4:
            //            label4.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 5:
            //            label5.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 6:
            //            label6.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 7:
            //            label7.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 8:
            //            label8.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 9:
            //            label9.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 10:
            //            label10.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 11:
            //            label11.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 12:
            //            label12.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 13:
            //            label13.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 14:
            //            label14.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 15:
            //            label15.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 16:
            //            label16.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 17:
            //            label17.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 18:
            //            label18.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 19:
            //            label19.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 20:
            //            label20.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        case 21:
            //            label21.Text = String.Format("{0} - {1}", item, price);
            //            break;
            //        default:
            //            break;
            //    }
            //    x++;
            //}
        }
        
        public void getPrice(string Data)
        {
            string Url = @"https://fcsapi.com/api/forex/latest?symbol=";
            string PostFix = @"&access_key=q0NKAX5YqeOstA88hNs0rIZ5dvK2z2IGeHtNK8t8ogzon9wE";
            WebRequest req = WebRequest.Create(Url + Data+ PostFix);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();

            textBox1.Text = Out;
            //API api = JsonConvert.DeserializeObject<API>(Out);
            //return api.response[0].price;
        }
    }
}
