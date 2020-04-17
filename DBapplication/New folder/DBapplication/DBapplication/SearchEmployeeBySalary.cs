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
    public partial class SearchEmployeeBySalary : Form
    {
        Controller controllerObj;
        string sign, order;
        User U;
        public SearchEmployeeBySalary(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
           
        }

        private void SearchEmployeeBySalary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Less.Checked == false && Equal.Checked == false && Greater.Checked == false)
            {
                MessageBox.Show("Please select a search parameter (Less, Equal, Greater)");
            }
            else
            {
                string Salary = sign + textBox1.Text;
                DataTable dt;
                if (U.Priv == Privileges.Admin) { dt = controllerObj.SelectEmployeeBySalary(Salary, order); }
                else if (U.Priv == Privileges.BranchManager) { dt = controllerObj.SelectEmployeeBySalaryAndBranch(Salary,order,U.BranchName); }
                else { dt = controllerObj.SelectEmployeeBySalaryAndBranchAndDepartment(Salary,order,U.BranchName,U.DepartmentName); }
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            
        }

        private void Less_CheckedChanged(object sender, EventArgs e)
        {
            sign="<";
            order = "Asc";
        }

        private void Equal_CheckedChanged(object sender, EventArgs e)
        {
            sign = "=";
            order = "Asc";
        }

        private void Greater_CheckedChanged(object sender, EventArgs e)
        {
            sign = ">";
            order = "Desc";
        }
    }
}
