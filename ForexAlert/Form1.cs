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
            getPrice("GBPUSD");
        }

        public void getCurrency()
        {
            List<string> listCurrency = new List<string>();
            listCurrency.Add("USDCHF");
            listCurrency.Add("GBPUSD");
            listCurrency.Add("EURUSD");
            listCurrency.Add("USDJPY");
            listCurrency.Add("USDCAD");
            listCurrency.Add("AUDUSD");
            listCurrency.Add("EURGBP");
            listCurrency.Add("EURCHF");
            listCurrency.Add("EURJPY");
            listCurrency.Add("GBPCHF");
            listCurrency.Add("CADJPY");
            listCurrency.Add("GBPJPY");
            listCurrency.Add("AUDNZD");
            listCurrency.Add("AUDCAD");
            listCurrency.Add("AUDCHF");
            listCurrency.Add("AUDJPY");
            listCurrency.Add("CHFJPY");
            listCurrency.Add("EURNZD");
            listCurrency.Add("EURCAD");
            listCurrency.Add("CADCHF");
            listCurrency.Add("NZDJPY");
            listCurrency.Add("NZDUSD");

            int x = 0;

            foreach (string item in listCurrency)
            {
                switch (x)
                {
                    case 1:
                        label1.Text = item;
                        break;
                    case 2:
                        label2.Text = item;
                        break;
                    case 3:
                        label3.Text = item;
                        break;
                    case 4:
                        label4.Text = item;
                        break;
                    case 5:
                        label5.Text = item;
                        break;
                    case 6:
                        label6.Text = item;
                        break;
                    case 7:
                        label7.Text = item;
                        break;
                    case 8:
                        label8.Text = item;
                        break;
                    case 9:
                        label9.Text = item;
                        break;
                    case 10:
                        label10.Text = item;
                        break;
                    case 11:
                        label11.Text = item;
                        break;
                    case 12:
                        label12.Text = item;
                        break;
                    case 13:
                        label13.Text = item;
                        break;
                    case 14:
                        label14.Text = item;
                        break;
                    case 15:
                        label15.Text = item;
                        break;
                    case 16:
                        label16.Text = item;
                        break;
                    case 17:
                        label17.Text = item;
                        break;
                    case 18:
                        label18.Text = item;
                        break;
                    case 19:
                        label19.Text = item;
                        break;
                    case 20:
                        label20.Text = item;
                        break;
                    case 21:
                        label21.Text = item;
                        break;
                    default:
                        break;
                }
                x++;
            }
        }
        
        public void getPrice(string Data)
        {
            string Url = @"https://www.freeforexapi.com/api/live";
            WebRequest req = WebRequest.Create(Url + "?pairs=" + Data);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            textBox1.Text = Out;
        }
    }
}
