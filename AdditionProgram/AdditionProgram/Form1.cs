using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdditionProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
                string num1 = textBox1.Text;
                string num2 = textBox2.Text;
                int a = Convert.ToInt32(num1);
                int b = Convert.ToInt32(num2);
                int c = a + b;
                MessageBox.Show("Addition of " + a + " and " + b + " = " + c);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Maroon;            
            label4.Text = "Program by Shubham Sajannavar [C172007]";
        }
    }
}
