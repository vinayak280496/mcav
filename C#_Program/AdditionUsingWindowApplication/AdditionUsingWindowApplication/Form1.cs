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
                textBox3.Text = (c.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show("Enter valid Numbers"+ex);                
                label3.Text=("Enter valid Numbers");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            label3.ForeColor = Color.Maroon;
            label4.ForeColor = Color.Red;            
            label4.Text = "Program is developed by CA172007 (Shubham Sajannavar) MCA 5th.";            
        }
    }
}
