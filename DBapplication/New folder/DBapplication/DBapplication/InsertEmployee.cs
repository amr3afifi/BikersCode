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
    public partial class InsertEmployee : Form
    {
        Controller controllerObj;
        User U;
        public InsertEmployee(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectBranches();
            if (U.Priv == Privileges.Admin)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Name";
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                comboBox1.Text = U.BranchName;
                if (U.Priv <= Privileges.BranchManager)
                {
                    DataTable dt2 = controllerObj.GetDepartmentNamesByBranch(comboBox1.Text);
                    comboBox2.DataSource = dt2;
                    comboBox2.DisplayMember = "Name";
                    comboBox2.ValueMember = "Name";
                    comboBox2.SelectedIndex = -1;
                }
                else comboBox2.Text = U.DepartmentName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ) //validation part
            {
                MessageBox.Show("Please insert all values");
            }
            else if (Convert.ToInt32(textBox2.Text) < 0)
            {
                MessageBox.Show("Please insert an appropriate salary");
            }
            else
            {
                string Mobile;
                if(textBox3.Text=="") Mobile="NULL";
                else Mobile=textBox3.Text;
                string Date= dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string Department = comboBox2.Text;
                if (Department == "") Department = "NULL";
                else Department = "'" + Department + "'";
                int r = controllerObj.InsertEmployee(textBox1.Text, textBox2.Text, Mobile, Date, Department, comboBox1.Text);
                if (r > 0)
                {
                    MessageBox.Show("Employee inserted successfully");
                    if(Department !="NULL") controllerObj.UpdateNumberOfEmployees(comboBox2.Text, comboBox1.Text, "+1");

                }
                else
                    MessageBox.Show("Error inserting employee");
            }
        }

        private void InsertEmployee_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            DataTable dt = controllerObj.GetDepartmentNamesByBranch(comboBox1.Text);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Name";
            comboBox2.SelectedIndex = -1;
        }
    }
}
