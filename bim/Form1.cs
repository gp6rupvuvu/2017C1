using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double meter = double.Parse(textBox1.Text);
            double bodyweight = double.Parse(textBox2.Text);
            double m = meter / 100;
            double value = (bodyweight / (m * m));
            label4.Text = value.ToString();

            int x;
            if (value < 18)
            {
                 x = 1;
            }
            else if (value > 35)
            {
                 x = 3;
            }
            else
            {
                 x = 2;
            }

            switch(x)
            {
                case 1:
                    textBox3.Text = "體重過輕";
                    break;
                case 2:
                    textBox3.Text = "體重剛好";
                    break;
                default:
                    textBox3.Text = "體重過重";
                    break;
            }
               
        }
    }
}
