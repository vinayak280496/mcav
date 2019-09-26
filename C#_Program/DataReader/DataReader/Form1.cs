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

namespace DataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            SqlCommand cmd = new SqlCommand("SELECT id FROM USER WHERE NAME=");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            try {
                string connetionString;
                SqlConnection conn;
                connetionString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=PSELF;Integrated Security=True; User ID=sa; Password=Password@123;";
                conn = new SqlConnection(connetionString);
                conn.Open();
                
                label3.Text = "Connected";
            } catch(Exception ex) {
                label3.Text = ("Not Connected"+ex);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
