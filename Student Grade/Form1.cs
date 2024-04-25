using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grade
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double maths, science, english, total, avg;
            string grade;
            maths = int.Parse(textMaths.Text);
            science = int.Parse(textScience.Text);
            english = int.Parse(textEnglish.Text);
            total = maths + science + english;
            textTotal.Text = total.ToString();
            avg = total / 3;
            textAvg.Text = avg.ToString();

            if(avg > 75)
            {
                grade = "A";
            }
            else if(avg >= 65)
            {
                grade = "B";
            }
            else if (avg >= 55 )
            {
                grade = "C";
            }
            else if(avg >= 45)
            {
                grade = "S";
            }
            else
            {
                grade = "F";
            }
            textGrade.Text = grade;
        }
    }
}
