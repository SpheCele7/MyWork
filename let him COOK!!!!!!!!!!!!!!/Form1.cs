using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace let_him_COOK______________
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int show = int.Parse(textBox1.Text);
            int ride = int.Parse(textBox2.Text);
            int combo = int.Parse(textBox3.Text);

            one_class fun = new one_class(show, ride, combo);

            label4.Text = "R" + fun.method().ToString();

            if (show >= 7 || ride >= 7 || combo >= 7)
                label5.Text = "you get free popcorn";
            else
                label5.Text = "buy more tickets to get free popcorn";
            {

            }

        }
    }
}
