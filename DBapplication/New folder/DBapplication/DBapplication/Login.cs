using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public enum Privileges
    {
        Admin=1,
        BranchManager=2,
        CustServiceDepartmentManager = 3,
        CustServiceDepartmentEmployee = 4,
        SalesDepartmentManager=5,
        SalesDepartmentEmployee=6,
        
    }

    public struct User
    {
        public Privileges Priv;
        public string Username, Password, BranchName, DepartmentName;
    }

    public partial class Login : Form
    {
        private bool _loggedin = false;
        private Controller controllerObj; // A Reference of type Controller 
                                          // (Initially NULL; NO Controller Object is created yet)

        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller(); // Create the Controler Object
        }

        //checks the username/password and returns the privlidges associated with this user
        //Returns 0 in case of error
        private int CheckPassword_Basic(string username, string password)
        {
            controllerObj = new Controller();
            return controllerObj.CheckPassword_Basic(username, password); 
            //return password == "1234";  //Password can be saved in the DB encrypted rather than being hardcoded.
                                        //Even if it is stored in a DB, keeping passwords in it's raw form is prone to attacks
        }
        
  
        private string CheckPassword_Hash(string password)
        {
            const string salt = "r4Nd0m_5A1t";  //They are concatenated to the password to protects against rainbow table attacks.
            HashAlgorithm algorithm = new SHA256Managed();
            string passwordandsalt = password + salt;
            string hashed = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordandsalt)));
            return hashed;   
        }


        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string password = CheckPassword_Hash(TxtBx_pass.Text);
            int privlg = controllerObj.CheckPassword_Basic(TxtBx_username.Text, password);
            privlg = Convert.ToInt32( TxtBx_username.Text);
            CheckPassword_Hash(TxtBx_pass.Text);
            //if (privlg > 0)
            //{
                _loggedin = true;
                User U;
                U.Priv = (Privileges) privlg;
                U.Username = TxtBx_username.Text;
                U.Password = password;
                if (U.Priv == Privileges.Admin) U.BranchName = "NULL";
                else U.BranchName = controllerObj.SelectUserBranchName(TxtBx_username.Text).ToString();
                if (U.Priv <= Privileges.BranchManager) U.DepartmentName = "NULL";
                else U.DepartmentName = controllerObj.SelectUserDepartmentName(TxtBx_username.Text).ToString();
                ProvidedFunctionalities PF = new ProvidedFunctionalities(U);
                PF.Show(this);
                TxtBx_pass.Clear();
                TxtBx_username.Clear();
                this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong username or password");
            //} 

        }

        
        //private void Login_FormClosing(object sender, FormClosingEventArgs e)
        //{
            //if (e.CloseReason == CloseReason.UserClosing && !_loggedin)
              //  Owner.Show();
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TxtBx_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
