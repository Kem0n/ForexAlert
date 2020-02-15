using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForexAlert
{
    public partial class AddNewPositionForm : Form
    {
        Temp t;
        Form1 form1 = new Form1();
        public AddNewPositionForm()
        {
            InitializeComponent();
            View(form1.getPrice());
        }

        public void View(API data)
        {
            foreach (var item in data.response)
            {
                comboBoxCurrency.Items.Add(item.symbol);
            }
        }

        private void buttonAddNewPosition_Click(object sender, EventArgs e)
        {
            t = new Temp(comboBoxCurrency.SelectedItem.ToString(),textBoxLoss.Text,textBoxTaik.Text,textBoxPrice.Text);
            this.Close();
        }
    }
}
