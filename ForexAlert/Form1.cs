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
        public Form1()
        {
            InitializeComponent();
            View(getPrice());
            listBox1.Items.Add("    Валютная пара       |      ЦЕНА      |      ТЕЙК      |       ЛОСС      ");
            listBox1.Items.Add("--------------------------------------------------------------------------------------------------------------------");
        }

        public void View(API data)
        {
            foreach (var item in data.response)
            {
                listBox3.Items.Add(item.symbol+" | "+item.price+" | "+item.change);

                if (item.change.Substring(0,1) == "-")
                {
                    listBox4.Items.Add(item.symbol + " | " + item.price + " | " + item.change);
                }
                else
                {
                    listBox5.Items.Add(item.symbol + " | " + item.price + " | " + item.change);
                }
            }
        }

        public API getPrice()
        {
            string Url = @"https://fcsapi.com/api/forex/latest?id=1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60&access_key=";
            string PostFix = @"&access_key=q0NKAX5YqeOstA88hNs0rIZ5dvK2z2IGeHtNK8t8ogzon9wE";
            WebRequest req = WebRequest.Create(Url + PostFix);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();

            API api = JsonConvert.DeserializeObject<API>(Out);
            return api;
        }

        public void AddNewPositionInForm1(string currency, string price, string taik, string loss)
        {
            listBox1.Items.Add(currency + " | " + price + " | " + " | " + taik + " | " + loss);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewPositionForm addform = new AddNewPositionForm();
            addform.ShowDialog();
            listBox1.Items.Add(Temp.currency + " | " + Temp.price + " | " + Temp.taik + " | " + Temp.loss);
        }
    }
}
