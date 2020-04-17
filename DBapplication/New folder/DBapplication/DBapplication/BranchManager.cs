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
    public partial class BranchManager : Form
    {
        Controller controllerObj = new Controller();
        public BranchManager()
        {
            InitializeComponent();
            textBox1.Enabled = false;
          DataTable dt=  controllerObj.SelectBranches();
          comboBox1.DataSource = dt;
          comboBox1.DisplayMember = "name";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectEmployeesIDbyNameAndBranch(comboBox2.Text,comboBox1.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "ID";
            comboBox3.ValueMember = "ID";

        }

        private void BranchManager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox3.Text != "")
            {
                int t = controllerObj.UpdateBranchManager(comboBox1.Text, Convert.ToInt32(comboBox3.Text));
                if (t >= 1)
                {
                    MessageBox.Show("Branch Manager Changed");
                    textBox1.Text = comboBox2.Text;
                    DataTable dt1 = controllerObj.SelectEmployeeDepartmentByID(comboBox3.Text);
                    string DepartmentName = dt1.Rows[0][0].ToString();
                    if(DepartmentName!="") controllerObj.UpdateNumberOfEmployees(DepartmentName, comboBox1.Text, "-1");
                    controllerObj.SetEmployeeDepartmentNULL(comboBox3.Text);
                }
                else { MessageBox.Show("Failed"); }
            }
            else
            {
                MessageBox.Show("No values entered");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            comboBox3.DataSource = null;
            comboBox3.Text = "";
            DataTable dt = controllerObj.SelectDistinctEmployeeNamesByBranch(comboBox1.Text);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";
            textBox1.Text = Convert.ToString(controllerObj.getBranchManager(comboBox1.Text)); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
