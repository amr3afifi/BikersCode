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
    public partial class ViewSupplierFEndDate : Form
    {
        Controller controllerObj;
        public ViewSupplierFEndDate()
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
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            DataTable dt = controllerObj.SelectSupplierByEnddate(date);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
