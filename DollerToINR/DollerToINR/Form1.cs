using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace DollerToINR
{
    public partial class Form1 : Form
    {
        string number = "1234567890";
        Double doller = 70.88;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = ("One doller $ is : "+doller.ToString());
                label4.ForeColor=Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cur1 = textBox1.Text;
            string cur2 = textBox2.Text;


            if (!textBox1.Text.Contains(number))
            {
                double converttoinr = doller * (Convert.ToDouble(cur1));
                textBox2.Text = converttoinr.ToString();

            }
            else {
                double converttodollr = doller * (Convert.ToDouble(cur2));
                textBox1.Text = converttodollr.ToString();
            }
                        
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
