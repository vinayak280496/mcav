using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pSELFDataSet1.Stud' table. You can move, or remove it, as needed.
            this.studTableAdapter1.Fill(this.pSELFDataSet1.Stud);
            // TODO: This line of code loads data into the 'pSELFDataSet.Stud' table. You can move, or remove it, as needed.
            this.studTableAdapter.Fill(this.pSELFDataSet.Stud);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studTableAdapter.FillBy(this.pSELFDataSet.Stud);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
