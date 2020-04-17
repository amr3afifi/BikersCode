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
    public partial class EditDepartment : Form
    {
        Controller controllerObj = new Controller();
        User U;
        public EditDepartment(User user)
        {
            InitializeComponent();
            U = user;
            textBox1.Enabled = false;
            if (U.Priv == Privileges.Admin)
            {
                DataTable dt2 = controllerObj.SelectBranches();
                comboBox1.DataSource = dt2;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "name";
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                comboBox1.Text = U.BranchName;
                comboBox1.Enabled = false;

                DataTable dt = controllerObj.SelectDepartmentNameByBranch(comboBox1.Text);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Name";
            }
            if (U.Priv > Privileges.BranchManager)
            {
                comboBox2.Text = U.DepartmentName;
                comboBox2.Enabled = false;
                comboBox4.Enabled = false;
                button2.Enabled = false;
            }


        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            DataTable dt = controllerObj.SelectAllDistinctEmployeeNames(comboBox1.Text,comboBox2.Text);
            comboBox5.DataSource = dt;
            comboBox5.DisplayMember = "name";
            comboBox5.ValueMember = "name";
            

            dt = controllerObj.GetDepartmentManager(comboBox2.Text, comboBox1.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Name";
            textBox1.Text = comboBox3.Text;
            comboBox3.DataSource = null;
                

            dt = controllerObj.SelectEmployeesIDbyName(comboBox5.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "id";
            comboBox3.ValueMember = "id";
            comboBox6.DataSource = dt;
            comboBox6.DisplayMember = "id";
            comboBox6.ValueMember = "id";

            dt = controllerObj.SelectAllDistinctEmployeeNames(comboBox1.Text, comboBox2.Text);
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "name";
            comboBox4.ValueMember = "name";

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controllerObj.DeleteEmployee(comboBox3.Text);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectEmployeesIDbyName(comboBox5.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "id";
            comboBox3.ValueMember = "id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r=controllerObj.UpdateDepartmentManager(comboBox1.Text, comboBox2.Text,Convert.ToInt32(comboBox6.SelectedValue));
            if (r > 0)
            {
                MessageBox.Show("Department manager changed successfully");
                textBox1.Text = comboBox4.Text;
            }
            else
            {
                MessageBox.Show("Error changing Department manager");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectEmployeesIDbyName(comboBox4.Text);
            comboBox6.DataSource = dt;
            comboBox6.DisplayMember = "id";
            comboBox6.ValueMember = "id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectDepartmentNameByBranch(comboBox1.Text);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Name";
        }
    }
}
