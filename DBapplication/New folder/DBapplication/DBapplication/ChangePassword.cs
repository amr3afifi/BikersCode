using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ChangePassword : Form
    {
        User U;
        private Controller controllerObj;
        public ChangePassword(User user)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.U = user;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private string CheckPassword_Hash(string password)
        {
            const string salt = "r4Nd0m_5A1t";  //They are concatenated to the password to protects against rainbow table attacks.
            HashAlgorithm algorithm = new SHA256Managed();
            string passwordandsalt = password + salt;
            string hashed = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordandsalt)));
            return hashed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Oldpass = CheckPassword_Hash(textBox1.Text);
            if (Oldpass != U.Password)
            {
                MessageBox.Show("Wrong Password");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                U.Password = CheckPassword_Hash(textBox2.Text);
                int r = controllerObj.UpdatePassword(U.Username, U.Password);
                if (r > 0)
                    MessageBox.Show("Password changed");
                else
                    MessageBox.Show("Error changing password");

            }
        }
    }
}
