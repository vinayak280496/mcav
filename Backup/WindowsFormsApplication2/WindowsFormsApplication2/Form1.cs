﻿using System;
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
            try {
                int year = Convert.ToInt32(textBox1.Text);
                
                if (year % 400 == 0 || year % 100 == 0 || year % 4 == 0)
                {
                    MessageBox.Show("Entered years(" + year + ") is a Leap Year");
                }
                else {
                    MessageBox.Show("Entered years(" + year + ") is not a Leap Year");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Please enter valid year.");
            }
        }
    }
}
