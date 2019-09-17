using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdditionUsingWindowApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a + b;
                label3.Text = ("Addition of " + a + " and " + b + " is " + c);
            }
            catch (Exception ex) {
                MessageBox.Show("Enter valid Numbers"+ex);                
                label3.Text=("Enter valid Numbers");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Maroon;
            label4.ForeColor = Color.Red;
            label3.Text = "Output will be display here";
            label4.Text = "Program is developed by CA172007 \n(Shubham Sajannavar) MCA 5th.";            
        }
    }
}
