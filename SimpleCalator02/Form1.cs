using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalator02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(true);//Calculate:小丸子
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(false);//Calculate:小丸子
        }
        private void Calculate(bool add)//小丸子爺爺呼叫小丸子
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            if (add)//這裡的add是add==true
            {
                label1.Text = (x + y).ToString();
            }
            else
            {
                label1.Text = (x - y).ToString();
            }
        }
    }
}
