using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double sum = 0;

            string name = Convert.ToString(this.textBox1.Text);

            double english = Convert.ToDouble(textBox2.Text);
            sum += english;

            double math = Convert.ToDouble(textBox3.Text);
            sum += math;

            double science = Convert.ToDouble(textBox4.Text);
            sum += science;

            double filipino = Convert.ToDouble(textBox5.Text);
            sum += filipino;

            double history = Convert.ToDouble(textBox6.Text);
            sum += history;

            double average = sum / 5;

            label8.Text = (average >= 75.00) ? ("The student passed. \n The general average of " + name + " is " + average) : label8.Text = ("The student failed. \n The general average of " + name + " is " + average);
     
        }

    }
}
