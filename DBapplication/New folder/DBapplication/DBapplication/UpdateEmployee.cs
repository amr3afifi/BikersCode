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
    public partial class UpdateEmployee : Form
    {
        Controller controllerObj;
        User U;
        string OldDepartmentName, OldBranchName;
        public UpdateEmployee(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
            DataTable dt= controllerObj.SelectEmployeeID();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
            
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

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
                string Salary = Convert.ToString(dataGridView1.Rows[0].Cells["Salary"].Value);
                string Mobile = Convert.ToString(dataGridView1.Rows[0].Cells["Mobile"].Value);
                if (Mobile == "") Mobile = "NULL";
                DateTime Date = Convert.ToDateTime(dataGridView1.Rows[0].Cells["date_of_hiring"].Value);
                string HiringDate = Date.ToString("yyyy-MM-dd");
                string DepName = Convert.ToString(dataGridView1.Rows[0].Cells["department_name"].Value);
                if (DepName == "") DepName = "NULL";
                else DepName = "'" + DepName + "'";
                string BranchName = Convert.ToString(dataGridView1.Rows[0].Cells["branch_name"].Value);
                DataTable dt = controllerObj.SelectEmployeeDepartmentByID(comboBox1.Text);
                OldDepartmentName = dt.Rows[0][0].ToString();
                string OldBranchName = controllerObj.SelectEmployeeBranchByID(comboBox1.Text).ToString();

                int r = controllerObj.UpdateEmployee(Name, Salary, Mobile, HiringDate, DepName, BranchName, comboBox1.Text);
                if (r > 0)
                {
                    MessageBox.Show("Updated successfully");
                    if (OldDepartmentName != "")
                    {
                        controllerObj.UpdateNumberOfEmployees(OldDepartmentName, OldBranchName, "-1");
                    }
                    controllerObj.UpdateNumberOfEmployees(DepName, BranchName, "+1");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectEmployeeByID(comboBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            if (U.Priv == Privileges.Admin) { dt = controllerObj.SelectEmployeeByName(textBox1.Text); }
            else if (U.Priv == Privileges.BranchManager) {  dt = controllerObj.SelectEmployeeByNameAndBranch(textBox1.Text,U.BranchName); }
            else {  dt = controllerObj.SelectEmployeeByNameAndBranchAndDepartment(textBox1.Text,U.BranchName,U.DepartmentName); }
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
        }
    }
}
