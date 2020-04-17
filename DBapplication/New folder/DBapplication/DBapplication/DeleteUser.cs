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
    public partial class DeleteUser : Form
    {
        Controller controllerObj;
        public DeleteUser()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetAllUsernames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Username";
            comboBox1.ValueMember = "Username";
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteUser(comboBox1.Text);
            if (r > 0)
            {
                MessageBox.Show("User deleted successfully");
                DataTable dt = controllerObj.GetAllUsernames();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Username";
                comboBox1.ValueMember = "Username";
            }
            else
                MessageBox.Show("Error deleting user");
        }
    }
}
