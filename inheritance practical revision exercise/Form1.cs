using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance_practical_revision_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = Double.Parse(textBox1.Text);
            double a2 = Double.Parse(textBox2.Text);
            double a3 = Double.Parse(textBox3.Text);
          double f = Double.Parse(textBox4.Text);
            

           

            if (radioButton2.Checked)
            {
                studentSubjectRecord CM = new studentSubjectRecord(a1, a2, a3, f);

                label5.Text = "the final mark is: " + CM.finalmark() + " and course mark is: " + CM.coursemark();

            
            }

        else if (radioButton3.Checked)
            {
                exhchangeModule EX = new exhchangeModule(a1,a2,a3,f,double.Parse(textBox5.Text));

                EX.propproject = double.Parse(textBox5.Text);

                label5.Text = "the course mark for exchange student is: " + EX.coursemark() + "final mark is:" + EX.finalmark2();


            
            
            } 


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
