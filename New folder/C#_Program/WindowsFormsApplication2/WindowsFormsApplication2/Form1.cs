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
            dataGridView1.Update();
            dataGridView1.Refresh();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pSELFDataSet.userdata' table. You can move, or remove it, as needed.
            this.userdataTableAdapter.Fill(this.pSELFDataSet.userdata);
            label3.ForeColor = Color.Red;
            connection = @"Data Source=DESKTOP-AC4AK63\SQLEXPRESS;Initial Catalog=PSELF;Integrated Security=True";
            conn = new SqlConnection(connection);
            conn.Open();            
            label3.Text = "connection established";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
    }
}
