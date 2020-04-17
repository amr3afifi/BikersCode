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
    public partial class InsertUser : Form
    {
        Controller controllerObj;
        public InsertUser()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetAllPrivileges();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Privilege";
            comboBox1.ValueMember = "Privilege";
            comboBox2.DataSource = null;
        }

        private void InsertUser_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1" || comboBox1.Text == "2")
            {
                comboBox3.DataSource = null;
            }
            else
            {
                DataTable dt = controllerObj.GetDepartmentNamesByBranch(comboBox2.Text);
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Name";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please, insert Username and Password for new user");
            }
            else if(comboBox1.Text!="1" && comboBox2.Text=="") MessageBox.Show("Please, pick a Branch");
            else if (comboBox1.Text != "1" && comboBox1.Text != "2" && comboBox3.Text == "") MessageBox.Show("Please, pick a Department");
            else
            {
                string DepartmentName, BranchName;
                BranchName = comboBox2.Text;
                DepartmentName = comboBox3.Text;
                if (BranchName == "") BranchName = "NULL";
                if (DepartmentName == "") DepartmentName = "NULL";
                int r = controllerObj.InsertUser(textBox1.Text,textBox2.Text,comboBox1.Text,comboBox2.Text,comboBox3.Text);
                if (r > 0)
                {
                    MessageBox.Show("New user inserted successfully");
                    controllerObj.UpdateNumberOfEmployees(comboBox2.Text, comboBox1.Text, "+1");
                }
                else
                    MessageBox.Show("Error inserting new user");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                comboBox2.DataSource = null;
            }
            else
            {
                DataTable dt = controllerObj.SelectBranches();
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Name";
            }
        }
    }
}
