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
    public partial class DeleteEmployee : Form
    {
        Controller controllerObj;
        User U;
        public DeleteEmployee(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            if (U.Priv == Privileges.Admin) { dt = controllerObj.SelectEmployeeByName(textBox1.Text); }
            else if (U.Priv == Privileges.BranchManager) { dt = controllerObj.SelectEmployeeByNameAndBranch(textBox1.Text, U.BranchName); }
            else { dt = controllerObj.SelectEmployeeByNameAndBranchAndDepartment(textBox1.Text, U.BranchName, U.DepartmentName); }
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = comboBox1.Text;
            DataTable dt1 = controllerObj.SelectEmployeeDepartmentByID(ID.ToString());
            string DepartmentName = dt1.Rows[0][0].ToString();
            string BranchName = controllerObj.SelectEmployeeBranchByID(ID.ToString()).ToString();
            int r = controllerObj.DeleteEmployee(ID);
            if (r > 0)
            {
                MessageBox.Show("Employee deleted successfully");
                if(DepartmentName!="") controllerObj.UpdateNumberOfEmployees(DepartmentName, BranchName, "-1");
                comboBox1.DataSource = null;
                comboBox1.Text = "";
                DataTable dt = controllerObj.SelectEmployeeByName(textBox1.Text);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ID";
                comboBox1.ValueMember = "ID";
            }
            else
                MessageBox.Show("Error deleting employee");
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
