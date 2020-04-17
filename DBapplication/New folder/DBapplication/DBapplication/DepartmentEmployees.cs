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
    public partial class DepartmentEmployees : Form
    {
        Controller controllerObj = new Controller();
        User U;

        public DepartmentEmployees(User user)
        {
            InitializeComponent();
            U = user;
            comboBox3.Visible = false;
            if (U.Priv > Privileges.Admin)
            {
                checkBox1.Enabled = false;
                comboBox1.Text = U.BranchName;
                comboBox1.Enabled = false;
            }
            if (U.Priv > Privileges.BranchManager)
            {
                checkBox2.Enabled = false;
                comboBox2.Text = U.DepartmentName;
                comboBox2.Enabled = false;
            }
        }

        private void DepartmentEmployees_Load(object sender, EventArgs e)
        {

        }

        private void DepartmentEmployees_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DataTable dt2 = controllerObj.SelectBranches();
                comboBox1.DataSource = dt2;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "name";

            }
            else
            {
                comboBox1.DataSource = new string[] { "" };
                if (checkBox2.Checked == true)
                {
                    DataTable dt3 = controllerObj.SelectDepartmentName();
                    comboBox2.DataSource = dt3;
                    comboBox2.DisplayMember = "name";
                    comboBox2.ValueMember = "name";
                }
            
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text != "" && checkBox2.Checked == true)
            {
                DataTable dt = controllerObj.SelectDepartmentNameByBranch(comboBox1.Text);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "name";
            }
            else if (checkBox2.Checked == true)
            {
                DataTable dt3 = controllerObj.SelectDepartmentName();
                comboBox2.DataSource = dt3;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "name";
            }
            else
            {
                comboBox2.DataSource = new string[] { "" };
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            
            DataTable dt = controllerObj.GetNumberofEmployees(comboBox1.Text, comboBox2.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Number";
            comboBox3.ValueMember = "Number";
            textBox1.Text = comboBox3.Text;

            dt = controllerObj.GetManagerName(comboBox1.Text, comboBox2.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Name";
            textBox2.Text = comboBox3.Text;

            dt = controllerObj.AvgSalary(comboBox1.Text, comboBox2.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Number";
            textBox4.Text = comboBox3.Text;

            dt = controllerObj.MaxSalary(comboBox1.Text, comboBox2.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Number";
            textBox5.Text = comboBox3.Text;

            dt = controllerObj.MINSalary(comboBox1.Text, comboBox2.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Number";
            textBox3.Text = comboBox3.Text;

            comboBox3.Visible = false;

            dataGridView1.DataSource = controllerObj.GetEmployees(comboBox1.Text, comboBox2.Text);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                DataTable dt = controllerObj.SelectDepartmentNameByBranch(comboBox1.Text);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "name";
            }
        }


    }
}