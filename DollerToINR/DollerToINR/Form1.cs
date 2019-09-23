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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {                       
            
            string conn = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=PSELF; User ID=sa;Password=Password@123";
            string query = "SELECT * FROM user_data";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "user_data");
            dataGridView1.DataSource=ds.Tables["user_data"];
            label1.Text = "Records Updated";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=PSELF; User ID=sa;Password=Password@123";
            string query = "SELECT * FROM user_data";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "user_data");

            ds.Tables["user_data"].Rows[1]["id"] = "100";
            
            label1.Text = ("Data Updated Successfully");
            dataGridView1.DataSource = ds.Tables["user_data"];       

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=PSELF; User ID=sa;Password=Password@123";
            string query = "SELECT * FROM user_data";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "user_data");
            DataRow row = ds.Tables["user_data"].NewRow();
            row["id"]="1212";
            row["name"] = "asdasds";
            row["last_name"] = "asfd";
            ds.Tables["user_data"].Rows.Add(row);

            SqlCommandBuilder scb = new SqlCommandBuilder(adp);
            adp.Update(ds.Tables["user_data"]);

            label1.Text = ("Data Inserted Successfully");            
            dataGridView1.DataSource = ds.Tables["user_data"];                
        }
    }
}
