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
    public partial class ViewBillFBranch : Form
    {
        Controller controllerObj;
        public ViewBillFBranch()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectBranches();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectBillByBranch(comboBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllBills();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
