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
    public partial class AddDepartment : Form
    {
        Controller controllerObj = new Controller();

        public AddDepartment()
        {
            InitializeComponent();

            comboBox1.DataSource = controllerObj.SelectBranches();
            comboBox1.DisplayMember = "name";
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = controllerObj.AddDepartment(textBox1.Text, comboBox1.Text);


            if (t >= 1) { MessageBox.Show("Department added"); }
            else
            {
                MessageBox.Show("Failed, maybe department_name exists or missing data to fill");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
