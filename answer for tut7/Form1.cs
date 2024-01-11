using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace answer_for_tut7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get all the users input
            int year = int.Parse(textBox2.Text);
            String name = textBox1.Text;
            String course = "", resType = "";
            if (radioButton1.Checked)
                course = "Masters IT";
            if (radioButton2.Checked)
                course = "Diploma in IT";
            if (radioButton3.Checked)
                course = "Dip in Textile";

            if (radioButton4.Checked)
                resType = "DUT Residence";
            if (radioButton5.Checked)
                resType = "Private Res";

            //create object
            if (checkBox1.Checked)
            {
                // since this is a disabled applicant we must now get information from the 
                // form that is needed for only disabled students

                double EV = double.Parse(textBox3.Text);
                string E = textBox4.Text;

                // now we create the object
                DisabledApplicant dObj = new DisabledApplicant(E, EV, name, course, resType, year);
                label8.Text = "R" + dObj.monthlyBux().ToString("00.00");
                label6.Text = "R" + dObj.totalBuxSemester().ToString("00.00");
            }
            else
            {	  //since they did not check the disabled box we can create a base class object
                mBuxApplicant objBux = new mBuxApplicant(name, course, resType, year);

                // call the methods to do the calculations and output
                label8.Text = "R" + objBux.monthlyBux().ToString("00.00");
                label6.Text = "R" + objBux.totalBuxSemester().ToString("00.00");
            }
        }

    }
}
