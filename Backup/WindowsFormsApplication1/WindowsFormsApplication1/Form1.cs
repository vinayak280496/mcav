using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
                string num1 = textBox1.Text;
                string num2 = textBox2.Text;

                int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                MessageBox.Show("Addition of " + num1 + " and " + num2 + " is " + sum);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
