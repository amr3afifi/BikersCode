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
    public partial class ViewSupplierFQuotaFilled : Form
    {
        Controller controllerObj;
        public ViewSupplierFQuotaFilled()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllSuppliers();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DataTable dt = controllerObj.SelectSupplierByQuotaFilled(textBox1.Text, '>');
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }

            else if (radioButton2.Checked)
            {
                DataTable dt = controllerObj.SelectSupplierByQuotaFilled(textBox1.Text, '<');
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }
    }
}
