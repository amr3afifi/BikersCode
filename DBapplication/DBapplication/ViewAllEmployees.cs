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
    public partial class ViewAllEmployees : Form
    {
        Controller controllerObj;
        User U;
        public ViewAllEmployees(User user)
        {
            InitializeComponent();
            U = user;
            controllerObj = new Controller();
            DataTable dt;
            if (U.Priv == Privileges.Admin) { dt = controllerObj.SelectAllEmployees(); }
            else if (U.Priv == Privileges.BranchManager) { dt = controllerObj.SelectAllEmployeesByBranch(U.BranchName); }
            else { dt = controllerObj.SelectAllEmployeesByBranchAndDepartment(U.BranchName,U.DepartmentName); }
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void ViewAllEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
