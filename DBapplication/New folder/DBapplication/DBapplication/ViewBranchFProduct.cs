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
    public partial class ViewBranchFProduct : Form
    {
        Controller controllerObj;
        public ViewBranchFProduct()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllBillsXProduct();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectBillByProduct(textBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
