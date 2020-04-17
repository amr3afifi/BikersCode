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
    public partial class SearchEmployeeByName : Form
    {
        Controller controllerObj;
        User U;
        public SearchEmployeeByName(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
        }

        private void SearchEmployeeByName_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (U.Priv == Privileges.Admin) { dt = controllerObj.SelectEmployeeByName(textBox1.Text); }
            else if (U.Priv == Privileges.BranchManager) { dt = controllerObj.SelectEmployeeByNameAndBranch(textBox1.Text, U.BranchName); }
            else { dt = controllerObj.SelectEmployeeByNameAndBranchAndDepartment(textBox1.Text, U.BranchName, U.DepartmentName); }
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
