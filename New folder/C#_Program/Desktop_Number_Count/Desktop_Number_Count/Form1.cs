﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Desktop_Number_Count
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            
            for (int i = 1; i <= 100; i++)
            {
                label2.Text = ("Virus Uploading :"+i);
                progressBar1.Value = i;                 
                Thread.Sleep(100);
                if(i==100){
                    MessageBox.Show("Virus Upload Completed.");
                    Application.Exit();                    
                }

            }      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to logout.");
            Application.Exit();
        }
    }
}