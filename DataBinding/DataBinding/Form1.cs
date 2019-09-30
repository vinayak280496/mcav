using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {            
                // TODO: This line of code loads data into the 'pSELFDataSet.Stud' table. You can move, or remove it, as needed.
                this.studTableAdapter.Fill(this.pSELFDataSet.Stud);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }
    }
}
