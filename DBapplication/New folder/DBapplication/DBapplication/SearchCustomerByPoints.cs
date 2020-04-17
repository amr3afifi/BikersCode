using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class SearchCustomerByPoints : Form
    {
        Controller controllerObj;
        string sign;
        public SearchCustomerByPoints()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void SearchCustomerByPoints_Load(object sender, EventArgs e)
        {

        }

        private void Less_CheckedChanged(object sender, EventArgs e)
        {
            sign = "<";
        }

        private void Equal_CheckedChanged(object sender, EventArgs e)
        {
            sign = "=";
        }

        private void Greater_CheckedChanged(object sender, EventArgs e)
        {
            sign = ">";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Less.Checked == false && Equal.Checked == false && Greater.Checked == false)
            {
                MessageBox.Show("Please select a search parameter (Less, Equal, Greater)");
            }
            else
            {
                string Points = sign + textBox1.Text;
                DataTable dt = controllerObj.SelectCustomerByPoints(Points);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }
    }
}
