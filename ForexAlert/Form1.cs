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
        int counter = 59;

        public Form1()
        {
            InitializeComponent();
            timerSuper.Enabled = true;
            timerSuper.Interval = 1000;
            View(getPrice());
        }

        public void View(API data)
        {


            var d = data.response.Select(i => i.symbol).ToArray();

            DataGridViewComboBoxCell cellSignal = (DataGridViewComboBoxCell)(dataGridViewSignal.Rows[0].Cells["CurrencyColumnSignal"]);
            cellSignal.DataSource = d;
            DataGridViewComboBoxCell cellCurrentPosition = (DataGridViewComboBoxCell)(dataGridViewCurrentPosition.Rows[0].Cells["СurrencyColumnCurrentPosition"]);
            cellCurrentPosition.DataSource = d;
            
            foreach (var item in data.response)
            {
                if (item.change.Substring(0,1) == "-")
                {
                    dataGridViewDown.Rows.Add(item.symbol,item.change);
                }
                else
                {
                    dataGridViewUp.Rows.Add(item.symbol, item.change);
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

        private void timerSuper_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                labelTime.Text = "00:" + counter;
            }
            else
            {
                counter = 59;
                labelTime.Text = "00:" + counter;
            }
                
        }
    }
}
