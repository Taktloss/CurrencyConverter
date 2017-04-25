using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Rate item in Money.GetRates(Currency.EUR))
            {
                richTextBox1.AppendText(item.CurrencyName + " = " + item.Value + "\n");
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                double result = Money.FromTo(int.Parse(textBox1.Text), Currency.EUR, Currency.AUD);
                textBox2.Text = result.ToString();
            }
        }
    }
}
