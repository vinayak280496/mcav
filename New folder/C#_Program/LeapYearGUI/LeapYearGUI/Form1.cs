using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeapYearGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Maroon;
            label3.ForeColor = Color.Red;
            label3.Text = "This Program developed by Shubham Sajannavar\nRoll No : CA172007";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long year = Convert.ToInt64(textBox1.Text);
                if (year % 400 == 0)
                {
                    label2.Text = (year + " is a Leap Year.");
                }
                else if (year % 100 == 0)
                {
                    label2.Text = (year + " is not a Leap Year.");
                }
                else if (year % 4 == 0)
                {
                    label2.Text = (year + " is a Leap Year.");
                }
                else
                {
                    label2.Text = (year + " is not a Leap Year.");
                }
            }
            catch (Exception ex) {
                label2.Text = "Enter Valid digit year";
            }
        }
    }
}
