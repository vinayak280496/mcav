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

namespace WindowsFormsApplication2
{    

    public partial class Form1 : Form
    {

        string connection;
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        SqlDataAdapter adp = new SqlDataAdapter();        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            string name = textBox1.Text;
            string email = textBox2.Text;

            sql = "insert into userdata (username,email) values ('"+name+"','"+email+"')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            label3.Text = "Record Inserted";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            connection = @"Data Source=DESKTOP-AC4AK63\SQLEXPRESS;Initial Catalog=PSELF;Integrated Security=True";
            conn = new SqlConnection(connection);
            conn.Open();
            label3.Text = "connection established";

        }
    }
}
