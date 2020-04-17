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
    public partial class ProvidedFunctionalities : Form
    {
        User U;
        public ProvidedFunctionalities(User user)
        {
            InitializeComponent();
            this.U =user;
            if (U.Priv != Privileges.Admin)
            {
                AddNewUser.Enabled = false;
                DeleteUser.Enabled = false;
                Branches.Enabled = false;
                AddDepartment.Enabled = false;
                ViewBillByBranch.Enabled = false;
                ViewShipmentBranch.Enabled = false;

                if (U.Priv != Privileges.BranchManager)
                {
                    AddShipment.Enabled = false;
                    UpdateShipment.Enabled = false;
                    EditShipment.Enabled = false;
                    AddSupplier.Enabled = false;
                    EditSupplier.Enabled = false;
                    DeleteSupp.Enabled = false;

                    if (U.Priv == Privileges.CustServiceDepartmentManager)
                    {
                        InsertProduct.Enabled = false;
                    }
                    else if (U.Priv == Privileges.CustServiceDepartmentEmployee)
                    {
                        Employees.Enabled = false;
                        Department.Enabled = false;
                        InsertProduct.Enabled = false;
                    }
                    else if (U.Priv == Privileges.SalesDepartmentManager)
                    {
                        AddCustomer.Enabled = false;
                        UpdateCustomer.Enabled = false;
                        AddBills.Enabled = false;
                    }
                    else if (U.Priv == Privileges.SalesDepartmentEmployee)
                    {
                        Employees.Enabled = false;
                        Department.Enabled = false;
                        AddCustomer.Enabled = false;
                        UpdateCustomer.Enabled = false;
                        AddBills.Enabled = false;
                    }

                }
            }
            
        }

        private void ProvidedFunctionalities_Load(object sender, EventArgs e)
        {

        }

        private void managersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BranchManager BM = new BranchManager();
            BM.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddDepartment AD = new AddDepartment();
            AD.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteBranch DB = new DeleteBranch();
            DB.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddBranch AB = new AddBranch();
            AB.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertCustomer IC = new InsertCustomer();
            IC.Show();
        }

        private void branchesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertEmployee IE = new InsertEmployee(U);
            IE.Show();
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            InsertUser IU = new InsertUser();
            IU.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassword CP = new ChangePassword(U);
            CP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEmployee UE = new UpdateEmployee(U);
            UE.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmployee DE = new DeleteEmployee(U);
            DE.Show();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchEmployeeByName SEN = new SearchEmployeeByName(U);
            SEN.Show();
        }

        private void bySalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchEmployeeBySalary SES = new SearchEmployeeBySalary(U);
            SES.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllEmployees VAE = new ViewAllEmployees(U);
            VAE.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateCustomer UC = new UpdateCustomer();
            UC.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void byNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchCustomerByName SCN = new SearchCustomerByName();
            SCN.Show();
        }

        private void byPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCustomerByPoints SCP = new SearchCustomerByPoints();
            SCP.Show();
        }

        private void AddBills_Click(object sender, EventArgs e)
        {
            InsertBill IB = new InsertBill(U);
            IB.Show();
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBillFDate VBD = new ViewBillFDate(U);
            VBD.Show();
        }

        private void byProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBillFProduct VBP= new ViewBillFProduct(U);
            VBP.Show();
        }

        private void byBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBillFBranch VBB = new ViewBillFBranch();
            VBB.Show();
        }

        private void byCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBillFCustomer VBC = new ViewBillFCustomer(U);
            VBC.Show();
        }

        private void byPriceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewBillFPrices VBP = new ViewBillFPrices(U);
            VBP.Show();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            InsertSupplier IS = new InsertSupplier();
            IS.Show();
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            UpdateSupplier US = new UpdateSupplier();
            US.Show();
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            DeleteSupplier DS = new DeleteSupplier();
            DS.Show();
        }

        private void byToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSupplierFName VSN = new ViewSupplierFName();
            VSN.Show();
        }

        private void byEndDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSupplierFEndDate VSED = new ViewSupplierFEndDate();
            VSED.Show();
        }

        private void byQuotaFilledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSupplierFQuotaFilled VSQF = new ViewSupplierFQuotaFilled();
            VSQF.Show();
        }

        private void AddShipment_Click(object sender, EventArgs e)
        {
            AddShipments AS = new AddShipments(U);
            AS.Show();
        }

        private void UpdateShipment_Click(object sender, EventArgs e)
        {
            ShipmentStatus SS = new ShipmentStatus(U);
            SS.Show();
        }

        private void EditShipment_Click(object sender, EventArgs e)
        {
            Edit_Shipment ES = new Edit_Shipment(U);
            ES.Show();
        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewShipmentsByPrice VSP = new ViewShipmentsByPrice(U);
            VSP.Show();
        }

        private void byOrderDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewShipemntsByOrderDate VSOD = new ViewShipemntsByOrderDate(U);
            VSOD.Show();
        }

        private void byArrivalDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewShipmentsbyArrivalDate VSAD = new ViewShipmentsbyArrivalDate(U);
            VSAD.Show();
        }

        private void bySupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewShipmentsBySuppliers VSS = new ViewShipmentsBySuppliers(U);
            VSS.Show();
        }

        private void byStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewShipmentByStatus VSS = new ViewShipmentByStatus(U);
            VSS.Show();
        }

        private void noFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewShipmentbyId VSID = new viewShipmentbyId(U);
            VSID.Show();
        }

        private void byBranchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewShipemntsByBranch VSB = new ViewShipemntsByBranch(U);
            VSB.Show();
        }

        private void ChangeDepartmentManager_Click(object sender, EventArgs e)
        {
            EditDepartment ED = new EditDepartment(U);
            ED.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentEmployees DE = new DepartmentEmployees(U);
            DE.Show();
        }

        private void addToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct();
            AP.Show();
        }

        private void viewAndUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product P = new Product(U);
            P.Show();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteProduct D = new DeleteProduct();
            D.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
