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
    public partial class UpdateCustomer : Form
    {
        Controller controllerObj;
        public UpdateCustomer()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectCustomerID();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectCustomerByID(comboBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Nothing was updated");
            }
            else
            {
                string Name = Convert.ToString(dataGridView1.Rows[0].Cells["Name"].Value);
                string Mobile = Convert.ToString(dataGridView1.Rows[0].Cells["Mobile"].Value);
                if (Mobile == "") Mobile = "NULL";
                string Points = Convert.ToString(dataGridView1.Rows[0].Cells["Points"].Value);
                if (Points == "") Points = "NULL";
                int r = controllerObj.UpdateCustomer(Name, Mobile, Points, comboBox1.Text);
                if (r > 0)
                {
                    MessageBox.Show("Updated successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectCustomerByName(textBox1.Text);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
        }
    }
}
