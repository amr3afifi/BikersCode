using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        public DataTable SelectBranches()
        {
            string query = "SELECT Name FROM Branch";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeID()
        {
            string query = "Select Id from Employee";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCustomerID()
        {
            string query = "Select Id from Customer";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeByID(string ID)
        {
            string query = "Select * from Employee where id =" + ID + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeByName(string Name)
        {
            string query = "Select * from Employee where Name ='" + Name + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeByNameAndBranchAndDepartment(string Name,string Branch,string Department)
        {
            string query = "Select * from Employee where Name ='" + Name + "'and [branch_name] = '" + Branch + "' and [department_name]='" + Department + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeByNameAndBranch(string Name, string Branch)
        {
            string query = "Select * from Employee where Name ='" + Name + "'and [branch_name] = '" + Branch + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCustomerByName(string Name)
        {
            string query = "Select * from Customer where Name ='" + Name + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllProductID()
        {
            string query = "Select [product_id] from Product;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllPrivileges()
        {
            string query = "Select distinct Privilege from Users;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllUsernames()
        {
            string query = "Select Username from Users;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDepartmentManager(string DepartmentName, string BranchName)
        {
            string query = "Select Employee.Name from Employee,Departments where Departments.[manager_id]=Employee.ID and Departments.Name='"+DepartmentName+"' and Departments.[branch_name]='"+BranchName+"'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeBySalary(string Salary,string Order)
        {
            string query = "Select * from Employee where Salary" + Salary + " Order by Salary " + Order + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeBySalaryAndBranch(string Salary, string Order,string Branch)
        {
            string query = "Select * from Employee where Salary" + Salary + "and [branch_name] = '" + Branch + "' Order by Salary " + Order + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeBySalaryAndBranchAndDepartment(string Salary, string Order,string Branch, string Department)
        {
            string query = "Select * from Employee where Salary" + Salary + "and [branch_name] = '" + Branch + "' and [department_name]='" + Department + "' Order by Salary " + Order + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCustomerByPoints(string Points)
        {
            string query = "Select * from Customer where Points" + Points + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCustomerByID(string ID)
        {
            string query = "Select * from Customer where id =" + ID + ";";
            return dbMan.ExecuteReader(query);
        }

        public int InsertEmployee(string Name,string Salary, string Mobile, string Date, string DepName,string BranchName)
        {
            string query = "INSERT INTO Employee(Name,Salary,Mobile,[date_of_hiring],[department_name],[branch_name])"+
            "VALUES ('"+Name+"',"+Salary+","+Mobile+",'"+Date+"',"+DepName+",'"+BranchName+"');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertUser(string Username, string Password, string Privilege, string BranchName, string DepartmentName)
        {
            string query = "Insert into Users Values('" + Username + "','" + Password + "'," + Privilege + ",'" + BranchName + "','" + DepartmentName + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEmployee(string Name,string Salary, string Mobile, string Date, string DepName,string BranchName, string ID)
        {
            string query = "Update Employee SET Name='"+Name+"', Salary="+Salary+", Mobile="+Mobile+", [date_of_hiring] = '"+Date+"', [department_name] = "+DepName+", [branch_name]='"+BranchName+"' where ID = "+ID+"";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateCustomer(string Name, string Mobile, string Points, string ID)
        {
            string query = "Update Customer Set Name='" + Name + "', Mobile =" + Mobile + ", Points= " + Points + " Where ID=" + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePassword(string Username,string Password)
        {
            string query = "Update Users Set Pass = '" + Password + "' where Username = '" + Username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateNumberOfEmployees(string DepartmentName, string BranchName,string UpdateValue)
        {
            string query = "Update Departments Set [number_of_employees] = [number_of_employees]"+UpdateValue+" where Name='"+DepartmentName+"' and [branch_name] = '"+BranchName+"';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertCustomer(string Name, string Mobile,string Points)
        {
            string query = "INSERT INTO Customer(Name,Mobile,Points) VALUES ('"+Name+"',"+Mobile.ToString()+","+Points.ToString()+")";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteUser(string Username)
        {
            string query = "DELETE FROM Users WHERE Username='" + Username + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetEmployeeDepartmentNULL(string ID)
        {
            string query = "update Employee set [department_name]=NULL where ID="+ID+";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetDepartmentNamesByBranch(string BranchName)
        {
            string query = "Select Name From Departments Where [branch_name]='"+BranchName+"'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllEmployees()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllEmployeesByBranch(string BranchName)
        {
            string query = "SELECT * FROM Employee  Where [branch_name]='" + BranchName + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDistinctEmployeeNamesByBranch(string BranchName)
        {
            string query = "SELECT Distinct Name FROM Employee  Where [branch_name]='" + BranchName + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllEmployeesByBranchAndDepartment(string BranchName,string DepartmentName)
        {
            string query = "SELECT * FROM Employee  Where [branch_name]='" + BranchName + "' and [department_name]='" + DepartmentName + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeeDepartmentByID(string ID)
        {
            string query = "Select [department_name] From Employee Where ID=" + ID + "";
            return dbMan.ExecuteReader(query);
        }

        public object SelectEmployeeBranchByID(string ID)
        {
            string query = "Select [branch_name] From Employee Where ID=" + ID + "";
            return (string)dbMan.ExecuteScalar(query);
        }

        public object SelectUserBranchName(string Username)
        {
            string query = "Select [branch_name] From Users Where Username='" + Username + "';";
            return (string)dbMan.ExecuteScalar(query);
        }

        public object SelectUserDepartmentName(string Username)
        {
            string query = "Select [department_name] From Users Where Username='" + Username + "';";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int CheckPassword_Basic(string username, string password)
        {
            string query = "Select Privilege from Users where Username = '"+username+"' and Pass='"+password+"'";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public int GetBillNumber()
        {
            string query = "SELECT MAX([bill_number]) FROM Bill";
            return (int)dbMan.ExecuteScalar(query);
        }


        public int GetProductAvailableQuantity(string PID)
        {
            string query = "Select Quantity FROM[Branch has Product] WHERE[product_id] =" + PID;
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }


        public int InsertBill(string customerid, string branchname, string date)
        {
            string query = "INSERT INTO Bill ([branch_name],[customer_id],[bill_date])" +
                            " Values ('" + branchname + "'," + customerid + ",'" + date + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertBillInvolvesProduct(int billnumber, string productid, string qty)
        {
            string query = "INSERT INTO [Bill Involves Product] ([bill_number],[product_id],[Quantity])" +
                            " Values (" + billnumber.ToString() + "," + productid + "," + qty + ");";

            return dbMan.ExecuteNonQuery(query);
        }


        public int UpdateQuantitySoldinBranch(string quantity, string pid, string branch)
        {
            string query = "UPDATE [Branch Sold Product] SET Quantity=Quantity+" + quantity +
                " WHERE [product_id]=" + pid + " AND [branch_name]='" + branch + "'";
            return dbMan.ExecuteNonQuery(query);

        }

        public int UpdateQuantityHasinBranch(string quantity, string pid, string branch)
        {
            string query = "UPDATE [Branch Has Product] SET Quantity=Quantity-" + quantity +
                 " WHERE [product_id]=" + pid + " AND [branch_name]='" + branch + "'";
            return dbMan.ExecuteNonQuery(query);

        }

        public int UpdateProductTotalStock(string quantity, string pid)
        {
            string query = "UPDATE [Product] SET [total_stock]=[total_stock]-" + quantity +
                 " WHERE [product_id]=" + pid;
            return dbMan.ExecuteNonQuery(query);

        }

        public int UpdateCustomerPoints(string price, string cid)
        {
            string query = "UPDATE [Customer] SET Points=Points+" + price + "WHERE ID=" + cid;
            return dbMan.ExecuteNonQuery(query);

        }

        public int UpdateProductQuantityOnBill(int billnumber, string pid, string quantity)
        {
            string query = "UPDATE [Bill Involves Product] SET Quantity=Quantity+" + quantity +
                "WHERE [product_id]=" + pid + "AND [bill_number]=" + billnumber;
            return dbMan.ExecuteNonQuery(query);

        }


        ////////////////////////EndofInsertBillQueries


        ////////////////////////InsertSupplierQueries


        public int InsertSupplier(string sname, string sdate, string edate, string quota)
        {
            string query = "INSERT INTO Supplier(Name,[start_date],[end_date],Quota,[quota_filled])" +
                            "Values ('" + sname + "','" + sdate + "','" + edate + "'," + quota+ ",0)";
            return dbMan.ExecuteNonQuery(query);
        }




        /////////////////////EndofInsertSupplierQueries

        ///////////////////DeleteSupplierQueries

        public int DeleteSupplier(string sname)
        {
            string query = "DELETE FROM Supplier WHERE Name='" + sname + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        //////////////////EndofDeleteSupplierQueries

        //////////////////ViewBillQueries

        public DataTable SelectBillByBranch(string branch)
        {
            string query = "SELECT [bill_number], [customer_id], [bill_date] FROM Bill WHERE [branch_name]='" + branch + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBills()
        {
            string query = "SELECT * FROM Bill";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBillsByBranch(string BranchName)
        {
            string query = "SELECT * FROM Bill where [branch_name] = '"+BranchName+"'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBillByDate(string date)
        {
            string query = "SELECT [bill_number], [branch_name], [customer_id] FROM Bill WHERE [bill_date]='" + date + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBillByDateAndBranch(string date,string BranchName)
        {
            string query = "SELECT [bill_number], [branch_name], [customer_id] FROM Bill WHERE [bill_date]='" + date + "' and [branch_name] = '" + BranchName + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBillByProduct(string pid)
        {
            string query = "SELECT  Bill.*,[Bill Involves Product].[product_id],[Bill Involves Product].Quantity " +
                "FROM Bill,[Bill Involves Product]" +
                " WHERE Bill.[bill_number]=[Bill Involves Product].[bill_number]" +
                " AND [product_id]=" + pid +
                "ORDER BY Bill.[bill_number] ";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBillByProductAndBranch(string pid,string BranchName)
        {
            string query = "SELECT  Bill.*,[Bill Involves Product].[product_id],[Bill Involves Product].Quantity " +
                "FROM Bill,[Bill Involves Product]" +
                " WHERE Bill.[bill_number]=[Bill Involves Product].[bill_number] and [branch_name] = '" + BranchName + "'" +
                " AND [product_id]=" + pid +
                "ORDER BY Bill.[bill_number] ";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBillsXProduct()
        {
            string query = "SELECT  Bill.*,[Bill Involves Product].[product_id],[Bill Involves Product].Quantity " +
                "FROM Bill,[Bill Involves Product]" +
                " WHERE Bill.[bill_number]=[Bill Involves Product].[bill_number]" +
                "ORDER BY Bill.[bill_number] ";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBillsXProductByBranch(string BranchName)
        {
            string query = "SELECT  Bill.*,[Bill Involves Product].[product_id],[Bill Involves Product].Quantity " +
                "FROM Bill,[Bill Involves Product]" +
                " WHERE Bill.[bill_number]=[Bill Involves Product].[bill_number] and Bill.[branch_name] = '" + BranchName + "'" +
                "ORDER BY Bill.[bill_number] ";

            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectAllBillsXPrice()
        {
            string query = "SELECT Bill.*,SUM(Price*Quantity) AS [Total Price] " +
                "FROM Bill,[Bill Involves Product],Product " +
                "WHERE Bill.[bill_number]=[Bill Involves Product].[bill_number]" +
                " AND [Bill Involves Product].[product_id]=Product.[product_id]" +
                " GROUP BY Bill.[bill_number],Bill.[branch_name],Bill.[customer_id],Bill.[bill_date]";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBillsXPriceByBranch(string BranchName)
        {
            string query = "SELECT Bill.*,SUM(Price*Quantity) AS [Total Price] " +
                "FROM Bill,[Bill Involves Product],Product " +
                "WHERE Bill.[bill_number]=[Bill Involves Product].[bill_number] and Bill.[branch_name] = '" + BranchName + "'" +
                " AND [Bill Involves Product].[product_id]=Product.[product_id]" +
                " GROUP BY Bill.[bill_number],Bill.[branch_name],Bill.[customer_id],Bill.[bill_date]";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBillsXPriceByPrice(string price, char op)
        {
            string query = "SELECT Bill.*,SUM(Price*Quantity) AS [Total Price] " +
                "FROM Bill,[Bill Involves Product], Product " +
                "WHERE Bill.[bill_number]=[Bill Involves Product].[bill_number] " +
                "AND[Bill Involves Product].[product_id]=Product.[product_id] " +
                "GROUP BY Bill.[bill_number], Bill.[branch_name], Bill.[customer_id], Bill.[bill_date] " +
                "HAVING SUM(Price* Quantity)" + op + "=" + price;

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllBillsXPriceByPriceAndBranch(string price, char op,string BranchName)
        {
            string query = "SELECT Bill.*,SUM(Price*Quantity) AS [Total Price] " +
                "FROM Bill,[Bill Involves Product], Product " +
                "WHERE Bill.[bill_number]=[Bill Involves Product].[bill_number] and Bill.[branch_name] = '" + BranchName + "'" +
                "AND[Bill Involves Product].[product_id]=Product.[product_id] " +
                "GROUP BY Bill.[bill_number], Bill.[branch_name], Bill.[customer_id], Bill.[bill_date] " +
                "HAVING SUM(Price* Quantity)" + op + "=" + price;

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBillByCustomer(string cid)
        {
            string query = "SELECT [bill_number], [branch_name], [bill_date] FROM Bill WHERE [customer_id]='" + cid + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBillByCustomerAndBranch(string cid,string BranchName)
        {
            string query = "SELECT [bill_number], [branch_name], [bill_date] FROM Bill WHERE [customer_id]='" + cid + "' [branch_name] = '" + BranchName + "'";
            return dbMan.ExecuteReader(query);
        }

        /////////////////EndofViewBillQueries

        /////////////////ViewSupplierQueries

        public DataTable SelectAllSuppliers()
        {
            string query = "SELECT * FROM Supplier";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectSupplierByName(string name)
        {
            string query = "SELECT [start_date],[end_date],[Quota],[quota_filledFilled] " +
                "FROM Supplier " +
                "WHERE Name='" + name + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectSupplierByEnddate(string date)
        {
            string query = "SELECT Name, [start_date],[end_date],[Quota],[quota_filledFilled] " +
                "FROM Supplier " +
                "WHERE [end_date]<='" + date + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectSupplierByQuotaFilled(string Quota, char op)
        {
            string query = "SELECT Name, [start_date],[end_date],[Quota],[quota_filledFilled] " +
                "FROM Supplier " +
                "WHERE [quota_filledFilled]" + op + "=" + Quota;
            return dbMan.ExecuteReader(query);
        }


        ///////////////EndofViewSupplierQueries


        ///////////UpdateSupplierQueries
        public int UpdateSupplier(string sname, string date, string quota)
        {
            if (date == "") date = "[end_date]";
            else date = "'" + date + "'";
            if (quota== "") quota= "Quota";
            string query = "UPDATE [Supplier] " +
                " SET [end_date]=" + date + ", Quota=" + quota+
                " WHERE Name='" + sname + "'";

            return dbMan.ExecuteNonQuery(query);

        }

        public int UpdateSupplierQuotaFilled(string sname, double quota, double qf, double oq)
        {
            double nqf = (((qf / 100) * oq) / quota) * 100;
            string query = "UPDATE [Supplier] " +
                " SET [quota_filledFilled]=" + nqf +
                " WHERE Name='" + sname + "'";

            return dbMan.ExecuteNonQuery(query);

        }

        public double GetQuota(string sname)
        {
            string query = "SELECT quota_filledFROM Supplier WHERE [Name]='" + sname + "'";
            return Convert.ToDouble(dbMan.ExecuteScalar(query));
        }

        public double GetQuotaFilled(string sname)
        {
            string query = "SELECT [quota_filledFilled] FROM Supplier WHERE [Name]='" + sname + "'";
            return Convert.ToDouble(dbMan.ExecuteScalar(query));
        }

        ///////////EndofUpdateSupplierQueries

        ///////////////////////ToMostafa

        public int InsertProductinBranchHas(string pid, string branch)
        {
            string query = "INSERT INTO [Branch Has Product]([product_id],[branch_name],Quantity)" +
                            "Values (" + pid + ",'" + branch + "',0)";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertProductinBranchSold(string pid, string branch)
        {
            string query = "INSERT INTO [Branch Sold Product]([product_id],[branch_name],Quantity)" +
                            "Values (" + pid + ",'" + branch + "',0)";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAllEmp()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectSupplier()
        {
            string query = "SELECT Name FROM Supplier";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ShipmentIDBySupplier()
        {
            string query = "SELECT Name FROM Supplier";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectShipments()
        {
            string query = "SELECT ID FROM Shipments";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectShipmentsNotArrived()
        {
            string query = "SELECT ID FROM Shipments Where Status <>'Arrived'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectShipmentsNotArrivedByBranch(string BranchName)
        {
            string query = "SELECT ID FROM Shipments Where Status <>'Arrived' and [branch_name] = '" + BranchName + "'";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectShipmentsUpdate()
        {
            string query = "SELECT ID FROM Shipments Where Status='Pending Confirmation' or status='Supplier Packing'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectShipmentsUpdateByBranch(string BranchName)
        {
            string query = "SELECT ID FROM Shipments Where (Status='Pending Confirmation' or status='Supplier Packing') and  [branch_name] = '" + BranchName + "'";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectDepartmentName()
        {
            string query = "SELECT DISTINCT Name FROM Departments";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDepartmentNameByBranch(string BranchName)
        {
            string query = "SELECT DISTINCT Name FROM Departments where [branch_name] = '"+BranchName+"'";
            return dbMan.ExecuteReader(query);
        }
       

        public int InsertShipment(DateTime Odate, DateTime Adate, string Bname)
        {
            string query = "INSERT INTO Shipments ([order_date], [arrival_date], [branch_name])" +
                            " Values ('" + Odate + "','" + Adate + "','" + Bname + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateShipStatus(int i, string s)
        {
            string query = "Update  Shipments  SET status= '" + s + "'   WHERE ID=" + i;

            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateShipmentArrivalDate(string Date,string ID)
        {
            string query = "Update Shipments set [arrival_date] = '"+Date+"' where id="+ID+";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetNumberofEmployees(string b, string d)
        {
            if (d == "" & b == "") { return null; }

            else if (b == "")
            {
                string query = "SELECT SUM([number_of_employees]) as Number FROM Departments Where Name='" + d + "'";
                return dbMan.ExecuteReader(query);
            }
            else if (d == "")
            {
                string query = "SELECT SUM([number_of_employees]) as Number FROM Departments Where [branch_name]='" + b + "'";
                return dbMan.ExecuteReader(query);
            }


            else
            {
                string query = "SELECT [number_of_employees] as Number FROM Departments Where [branch_name]='" + b + "' and Name='" + d + "'";
                return dbMan.ExecuteReader(query);

            }
        }

        public DataTable GetManagerName(string b, string d)
        {
            if (d != "" & b != "")
            {
                string query = "SELECT E.name FROM Departments AS D,Employee AS E Where D.[branch_name]='" + b + "' and D.Name='" + d + "' and ID=[manager_id]";
                return dbMan.ExecuteReader(query);

            }
            else return null;
        }

        public DataTable AvgSalary(string b, string d)
        {
            if (d == "" & b == "") { return null; }

            else if (b == "")
            {
                string query = "SELECT AVG(Salary) as Number FROM Employee Where [department_name]='" + d + "'";
                return dbMan.ExecuteReader(query);
            }
            else if (d == "")
            {
                string query = "SELECT AVG(Salary) as Number FROM Employee Where [branch_name]='" + b + "'";
                return dbMan.ExecuteReader(query);
            }


            else
            {
                string query = "SELECT AVG(Salary) as Number FROM Employee Where [branch_name]='" + b + "' and [department_name]='" + d + "'";
                return dbMan.ExecuteReader(query);

            }
        }

        public DataTable MaxSalary(string b, string d)
        {
            if (d == "" & b == "") { return null; }

            else if (b == "")
            {
                string query = "SELECT Max(Salary) as Number FROM Employee Where [department_name]='" + d + "'";
                return dbMan.ExecuteReader(query);
            }
            else if (d == "")
            {
                string query = "SELECT Max(Salary) as Number FROM Employee Where [branch_name]='" + b + "'";
                return dbMan.ExecuteReader(query);
            }


            else
            {
                string query = "SELECT Max(Salary) as Number FROM Employee Where [branch_name]='" + b + "' and [department_name]='" + d + "'";
                return dbMan.ExecuteReader(query);

            }
        }

        public DataTable MINSalary(string b, string d)
        {
            if (d == "" & b == "") { return null; }

            else if (b == "")
            {
                string query = "SELECT MIN(Salary) as Number FROM Employee Where [department_name]='" + d + "'";
                return dbMan.ExecuteReader(query);
            }
            else if (d == "")
            {
                string query = "SELECT MIN(Salary) as Number FROM Employee Where [branch_name]='" + b + "'";
                return dbMan.ExecuteReader(query);
            }


            else
            {
                string query = "SELECT MIN(Salary) as Number FROM Employee Where [branch_name]='" + b + "' and [department_name]='" + d + "'";
                return dbMan.ExecuteReader(query);

            }
        }

       

        public DataTable GetEmployees(string b, string d = "")
        {
            if (d == "" & b == "") { return null; }

            else if (b == "")
            {
                string query = "SELECT * FROM Employee   Where [department_name]='" + d + "'";
                return dbMan.ExecuteReader(query);
            }
            else if (d == "")
            {
                string query = "SELECT * FROM Employee   Where [branch_name]='" + b + "'";
                return dbMan.ExecuteReader(query);
            }


            else
            {
                string query = "SELECT * FROM Employee   Where [branch_name]='" + b + "' and [department_name]='" + d + "'";
                return dbMan.ExecuteReader(query);

            }
        }

        public DataTable SelectAllEmployeeNames(string b, string d)
        {
            string query = "SELECT name,id FROM Employee   Where [branch_name]='" + b + "' and [department_name]='" + d + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllDistinctEmployeeNames(string b, string d)
        {
            string query = "SELECT Distinct name FROM Employee   Where [branch_name]='" + b + "' and [department_name]='" + d + "'";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteEmployee(string ID)
        {
            string query = "DELETE FROM Employee WHERE ID=" + ID;
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectEmployeesIDbyName(string Name)
        {
            string query = "SELECT ID FROM Employee WHERE Name ='" + Name + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployeesIDbyNameAndBranch(string Name,string BranchName)
        {
            string query = "SELECT ID FROM Employee WHERE Name ='" + Name + "' and [branch_name]= '"+BranchName+"';";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateDepartmentManager(string b, string d, int m)
        {
            string query = "Update  Departments  SET [manager_id]= " + m + "   Where [branch_name]='" + b + "' and name='" + d + "'";

            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateBranchManager(string b, int m)
        {
            string query = "Update  Branch  SET [manager_id]= " + m + "   Where Name='" + b + "'";

            return dbMan.ExecuteNonQuery(query);
        }


        public object getBranchManager(string bname)
        {
            string query = "select name from Employee where Id=(select [manager_id] from Branch Where Name='" + bname + "')";

            return (string)dbMan.ExecuteScalar(query);
        }


        public int GetShipmentId()
        {
            string query = "select Max(ID) from Shipments";

            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable GetShipmentIdView()
        {
            string query = "select ID from Shipments";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentIdViewByBranch(string BranchName)
        {
            string query = "select ID from Shipments where [branch_name] = '"+BranchName+"'";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentDetails(int id)
        {
            string query = "select Status,[order_date],[arrival_date],Price,[branch_name] from Shipments Where ID=" + id + "";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentIDbySupplierAndBranch(string n,string BranchName)
        {
            string query = "SELECT distinct b.[shipment_id] FROM [Shipment Contains Product] as b,Shipments where (exists (select a.[product_id] from Product as a where b.[product_id]=a.[product_id] and a.[supplier_name]='"+n+"')) and Shipments.ID=b.[shipment_id] and Shipments.[branch_name] = '"+BranchName+"'";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentIDbySupplier(string n)
        {
            string query = "SELECT distinct b.[shipment_id] FROM [Shipment Contains Product] as b where (exists (select a.[product_id] from Product as a where b.[product_id]=a.[product_id] and a.[supplier_name]='" + n + "'";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentIDbyStatus(string n)
        {
            string query = "SELECT distinct ID FROM Shipments where status='" + n + "'";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentIDbyStatusAndBranch(string n,string BranchName)
        {
            string query = "SELECT distinct ID FROM Shipments where status='" + n + "' and [branch_name] = '"+BranchName+"";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentIDbyBranch(string n)
        {
            string query = "SELECT distinct ID FROM Shipments where [branch_name]='" + n + "'";

            return dbMan.ExecuteReader(query);
        }


        public DataTable GetShipmentByOrderDate(DateTime d, int n)
        {
            string query;

            if (n == 0)
            { query = "SELECT  ID FROM Shipments where [order_date]='" + d + "'"; }
            else if (n == 1)
            { query = "SELECT  ID FROM Shipments where [order_date]>'" + d + "'"; }
            else if (n == 2)
            { query = "SELECT  ID FROM Shipments where [order_date]<'" + d + "'"; }
            else { query = ""; }

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentByOrderDateAndBranch(DateTime d, int n,string BranchName)
        {
            string query;

            if (n == 0)
            { query = "SELECT  ID FROM Shipments where [order_date]='" + d + "' and [branch_name]='" + BranchName + "'"; }
            else if (n == 1)
            { query = "SELECT  ID FROM Shipments where [order_date]>'" + d + "' and [branch_name]='" + BranchName + "'"; }
            else if (n == 2)
            { query = "SELECT  ID FROM Shipments where [order_date]<'" + d + "' and [branch_name]='" + BranchName + "'"; }
            else { query = ""; }

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentsByPrice(float d, int n)
        {
            string query;

            if (n == 0)
            { query = "SELECT  ID FROM Shipments where Price=" + d + ""; }
            else if (n == 1)
            { query = "SELECT  ID FROM Shipments where Price>" + d + ""; }
            else if (n == 2)
            { query = "SELECT  ID FROM Shipments where Price<" + d + ""; }
            else { query = ""; }

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentsByPriceAndBranch(float d, int n,string BranchName)
        {
            string query;

            if (n == 0)
            { query = "SELECT  ID FROM Shipments where Price=" + d + " and [branch_name]='" + BranchName + "'"; }
            else if (n == 1)
            { query = "SELECT  ID FROM Shipments where Price>" + d + " and [branch_name]='" + BranchName + "'"; }
            else if (n == 2)
            { query = "SELECT  ID FROM Shipments where Price<" + d + " and [branch_name]='" + BranchName + "'"; }
            else { query = ""; }

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentByArrivalDate(DateTime d, int n)
        {
            string query;

            if (n == 0)
            { query = "SELECT  ID FROM Shipments where [arrival_date]='" + d + "' and status='Arrived'"; }
            else if (n == 1)
            { query = "SELECT  ID FROM Shipments where [arrival_date]>'" + d + "'and status='Arrived'"; }
            else if (n == 2)
            { query = "SELECT  ID FROM Shipments where [arrival_date]<'" + d + "'and status='Arrived'"; }
            else { query = ""; }

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetShipmentByArrivalDateAndBranch(DateTime d, int n,string BranchName)
        {
            string query;

            if (n == 0)
            { query = "SELECT  ID FROM Shipments where [arrival_date]='" + d + "' and status='Arrived' and [branch_name]='" + BranchName + "'"; }
            else if (n == 1)
            { query = "SELECT  ID FROM Shipments where [arrival_date]>'" + d + "'and status='Arrived' and [branch_name]='" + BranchName + "'"; }
            else if (n == 2)
            { query = "SELECT  ID FROM Shipments where [arrival_date]<'" + d + "'and status='Arrived' and [branch_name]='" + BranchName + "'"; }
            else { query = ""; }

            return dbMan.ExecuteReader(query);
        }


        public DataTable GetShipemntItems(int id)
        {
            string query = "Select a.[product_id],Quantity,[supplier_name] from [Shipment Contains Product] as a inner join Product as b on b.[product_id]=a.[product_id] where [shipment_id]=" + id + "";

            return dbMan.ExecuteReader(query);
        }


        public int AddBranch(string n, string a)
        {
            string query = "insert into branch(Name,Adress) values('" + n + "','" + a + "')";

            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteBranch(string n)
        {
            string query = "delete from branch where name='" + n + "'";

            return dbMan.ExecuteNonQuery(query);
        }

        public int AddDepartment(string n, string b)
        {
            string query = "insert into Departments(Name,[branch_name]) values ('" + n + "','" + b + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddProduct(string s, float p)
        {
            string query = "INSERT INTO Product ([supplier_name],Price) " +
                                    "Values ('" + s + "'," + p + ");";


            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertAcc(string t, string s)
        {
            string query = "INSERT INTO Accessory ([accessory_id],Type,Size) Values ((select MAX([product_id]) from Product),'" + t + "','" + s + "');";
            return dbMan.ExecuteNonQuery(query);
        }


        public int Insertmotor(string model, string type, int year, int cc, string color)
        {

            string query = "INSERT INTO Motorcycle ([motorcycle_id],Model,Type,Year,CC,Color) Values ((select MAX([product_id]) from Product),'" + model + "' ,'" + type + "'," + year + "," + cc + ",'" + color + "');";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetMotorCycleByName(string t)
        {
            string query = "Select* From MotorCycle Where Model Like '%" + t + "%'";
            return dbMan.ExecuteReader(query);
        }







        public DataTable GetMotorCycleId()
        {
            string q = "select [motorcycle_id] From MotorCycle order by[motorcycle_id]";


            return dbMan.ExecuteReader(q);

        }



        public int InsertSparePart(string t, string c, int i)
        {
            string query = "insert into SpareParts([spareparts_id],Type,Condition,[Belonging_motorcycle_id]) values ((select MAX([product_id]) from Product),'" + t + "','" + c + "'," + i + ")";

            return dbMan.ExecuteNonQuery(query);
        }



        public DataTable GetItemIDbyType(string t)
        {
            string q;

            if (t == "MotorCycle") { q = "select [motorcycle_id] From MotorCycle order by[motorcycle_id]"; }
            else if (t == "SparePart") { q = "select [spareparts_id] From SpareParts order by[spareparts_id]"; }
            else if (t == "Accessory") { q = "select [accessory_id] From Accessory order by[accessory_id]"; }
            else { q = ""; }

            return dbMan.ExecuteReader(q);

        }
        public DataTable GetItemDetailByName(string t, string n)
        {
            string q;

            if (n == "MotorCycle")
            { q = "Select MotorCycle.*,Product.Price,Product.[supplier_name] From MotorCycle,Product Where Model Like '%" + t + "%' and [product_id]=[motorcycle_id]"; }
            else if (n == "SparePart")
            { q = "Select SpareParts.*,Product.Price,Product.[supplier_name] From SpareParts,Product Where Type Like '%" + t + "%' and [product_id]=[spareparts_id]"; ; }
            else if (n == "Accessory")
            { q = "Select Accessory.*,Product.Price,Product.[supplier_name] From Accessory,Product Where Type Like '%" + t + "%' and [product_id]=[accessory_id]"; ; }
            else { q = ""; }
            return dbMan.ExecuteReader(q);

        }

        public DataTable GetShipmentItems(int i)
        {
            string q = "select [product_id] From [Shipment Contains Product] where [shipment_id]=" + i + "";


            return dbMan.ExecuteReader(q);

        }



        public int AddItemToShipment(int SHD, int PID, int q)
        {
            string query = "INSERT INTO [Shipment Contains Product] values (" + SHD + "," + PID + "," + q + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateShipmentPrice(string Price,string ID)
        {
            string query = "Update Shipments Set Price=Price+"+Price+" where Id="+ID+";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int ShipmentArrived(int id)
        {
            string q = "Update [Branch has Product] set Quantity=Quantity+(select Quantity from [Shipment Contains Product] as SHP" +
                       " where SHP.[product_id]=[Branch has Product].[product_id]  and SHP.[shipment_id]=" + id + ")" +
                       " where [branch_name]=(select [branch_name] from Shipments where ID=" + id + ")";

            return dbMan.ExecuteNonQuery(q);
        }

        public int UpdateProductTotalStockFromShipment(string shipmentID)
        {
            string q = "Update Product set [total_stock]=[total_stock]+(Select Quantity from [Shipment Contains Product] as SCP where SCP.[product_id] = Product.[product_id] and SCP.[shipment_id]="+shipmentID+") where Product.[product_id] In (Select [product_id] from [Shipment Contains Product] where [shipment_id] = "+shipmentID+")";
            return dbMan.ExecuteNonQuery(q);
        }

        public int UpdateShipmentItems(int sh, int pr, int q)
        {
            string query = "update [Shipment Contains Product] set Quantity=" + q + " where [shipment_id]=" + sh + " and [product_id]=" + pr + "";
            return dbMan.ExecuteNonQuery(query);

        }
        public int DeleteShipmentItems(int sh, int pr)
        {
            string q = "Delete [Shipment Contains Product]  where [shipment_id]=" + sh + " and [product_id]=" + pr + "";
            return dbMan.ExecuteNonQuery(q);

        }

        public int GetProductID()
        {
            string query = "SELECT MAX([product_id]) FROM Product";
            return (int)dbMan.ExecuteScalar(query);
        }

        public double GetProductPrice(string ID)
        {
            string query = "Select Price from Product where [product_id] ="+ID+";";
            return (double)dbMan.ExecuteScalar(query);
        }

        public DataTable showoutallmotor()
        {
            string query = "SELECT * FROM Motorcycle,Product WHERE [motorcycle_id]=[product_id] AND [total_stock]=0";
            return dbMan.ExecuteReader(query);
        }
        public DataTable showoutallsp()
        {
            string query = "SELECT * FROM SpareParts,Product WHERE [spareparts_id]=[product_id] AND [total_stock]=0";
            return dbMan.ExecuteReader(query);
        }

        public DataTable showoutallacc()
        {
            string query = "SELECT * FROM Accessory,Product WHERE [accessory_id]=[product_id] AND [total_stock]=0";
            return dbMan.ExecuteReader(query);
        }

        public int Deleteproduct(int id)
          {


              string query = "DELETE FROM Product WHERE [product_id]=" + id ;
              //string query2 = "DELETE FROM Motorcycle WHERE [motorcycle_id]=" + id ;
              //string query3 = "DELETE FROM Sparepats WHERE [spareparts_id]=" + id ;
              //string query4 = "DELETE FROM Accessory WHERE [accessory_id]=" + id ;
              //  dbMan.ExecuteNonQuery(query2);
              //  dbMan.ExecuteNonQuery(query3);
              //  dbMan.ExecuteNonQuery(query4);
              return dbMan.ExecuteNonQuery(query);
          }

        public int deletebeltomotor(int id)
        {
            string query = "DELETE FROM SPAREPARTS WHERE [Belonging motorcycle_id]=" + id;
            return dbMan.ExecuteNonQuery(query);

        }

        public int incby(int id, int num)
          {

              string query = 
                  "UPDATE Product " +
                  "SET [total_stock]=[total_stock] + "+ num+
                  " WHERE [product_id]=" + id + " ;";
              return dbMan.ExecuteNonQuery(query);
          }

        public int decby(int id, int num)
          {
            string query1 =
                   "SELECT [total_stock] FROM Product " +
                   " WHERE [product_id]=" + id + " ;";
            if (num <= (int)dbMan.ExecuteScalar(query1))
            {
                string query2 =
                    "UPDATE Product " +
                    "SET [total_stock]=[total_stock] - " + num +
                    " WHERE [product_id]=" + id + " ;";
                return dbMan.ExecuteNonQuery(query2);
            }
            else { MessageBox.Show("Product total_stock is less than the number you entered please try again");return 0; }
            }

        public DataTable showallmotor()
          {
              string query = "SELECT Motorcycle.*,Product.Price,Product.[total_stock],Product.[supplier_name] FROM Motorcycle,Product WHERE [product_id]=[motorcycle_id];";
              return dbMan.ExecuteReader(query);
          }

        public DataTable showallsp()
        {
            string query = "SELECT SpareParts.*,Product.Price,Product.[total_stock],Product.[supplier_name] FROM SpareParts,Product WHERE [spareparts_id]=[product_id];";
            return dbMan.ExecuteReader(query);
        }

        public DataTable showallacc()
        {
            string query = "SELECT Accessory.*,Product.Price,Product.[total_stock],Product.[supplier_name] FROM Accessory,Product WHERE [accessory_id]=[product_id];";
            return dbMan.ExecuteReader(query);
        }

        public int Countmotor()
          {
              string query = "SELECT COUNT([motorcycle_id]) FROM Motorcycle;";
              return (int)dbMan.ExecuteScalar(query);
          }

        public int Countsp()
        {
            string query = "SELECT COUNT([spareparts_id]) FROM SpareParts;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int Countacc()
        {
            string query = "SELECT COUNT([accessory_id]) FROM Accessory;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable Searchmotor(string type)
        {
            string checkmotor = "Select [motorcycle_id],Price,[supplier_name],Model,Year,CC,Color,[total_stock]" +
                "FROM Motorcycle,Product" +
                " WHERE Model LIKE '%" + type + "%' and [motorcycle_id]=[product_id]";
            return dbMan.ExecuteReader(checkmotor);
        }

        public int GetMotorCycleInSpareparts(string pid)
        {
            string query = "select * from Motorcycle,Spareparts" +
            " where " + pid + "=[Belonging motorcycle_id] And [motorcycle_id]=" + pid;

            DataTable dt = dbMan.ExecuteReader(query);

            return dt.Rows.Count ;
        }

        public DataTable Searchspare(string type)
        {
            string checksp = "Select [spareparts_id],Price,[supplier_name],Type,Condition,[Belonging motorcycle_id],[total_stock]" +
                "FROM Spareparts,Product" +
                " WHERE [spareparts_id]=[product_id] AND Type LIKE '%" + type + "%';";
            return dbMan.ExecuteReader(checksp);
        }

        public DataTable Searchacc(string type)
        {
            string checkacc = "Select [accessory_id],Price,[supplier_name],Type,Size,[total_stock]" +
                    "FROM Accessory,Product" +
                    " WHERE [accessory_id]=[product_id] AND Type LIKE '%" + type + "%';";
            return dbMan.ExecuteReader(checkacc);
        }

        public int ifproductismotor(string pid)
        {
            string query = "select * from Motorcycle,Product where [product_id]="+pid+" AND [motorcycle_id]=[product_id]";

            return dbMan.ExecuteReader(query).Rows.Count;
        }

        public int ifproductissp(string pid)
        {
            string query = "select * from SPAREPARTS,Product" +
             " where [product_id]=" + pid + " AND [spareparts_id]=[product_id]";

            return dbMan.ExecuteReader(query).Rows.Count;
        }

        public int ifproductisacc(string pid)
        {
            string query = "select * from ACCESSORY,Product" +
             " where [product_id]=" + pid + " AND [accessory_id]=[product_id]";

            return dbMan.ExecuteReader(query).Rows.Count;
        }
       

        public int Updatepro(string id,string sname,string price)
        {
            
                string query = "UPDATE Product SET Price='" + price + "',[supplier_name]='" + sname + "' WHERE [product_id]='" + id+"' ;";
                return dbMan.ExecuteNonQuery(query);
        }
        //getters for moto update
        public int updatemotofunc(string id,string model,string type,string year,string cc,string color)
        {
            string query = "UPDATE MOTORCYCLE SET Type = '" + type +"',Model='"+ model + "',year='" + year + "', CC='" + cc + "',COLOR='" + color + "' WHere [motorcycle_id]=" + id;
            return dbMan.ExecuteNonQuery(query);
        }

        public object getsupname(string id)
        {
            string query = "Select Supplier_Name from Product Where Product_ID="+id ;
            return (string)dbMan.ExecuteScalar(query);
        }
        public object getprice(string id)
        {
            string query = "Select Price from Product Where Product_ID=" + id;
            return dbMan.ExecuteScalar(query).ToString() ;
        }
        public object getmodel(string id)
        {
            string query = "Select Model from Motorcycle Where Motorcycle_ID=" + id;
            return (string)dbMan.ExecuteScalar(query);
        }
        public object gettypem(string id)
        {
            string query = "Select Type from Motorcycle Where Motorcycle_ID=" + id;
            return (string)dbMan.ExecuteScalar(query);
        }
        public object getyear(string id)
        {
            string query = "Select Year from Motorcycle Where Motorcycle_ID=" + id;
            return dbMan.ExecuteScalar(query).ToString();
        }
        public object getcc(string id)
        {
            string query = "Select CC from Motorcycle Where Motorcycle_ID=" + id;
            return dbMan.ExecuteScalar(query).ToString();
        }
        public object getcolor(string id)
        {
            string query = "Select Color from Motorcycle Where Motorcycle_ID=" + id;
            return (string)dbMan.ExecuteScalar(query);
        }
        //getters for sp update
        public int updatespfunc(string id, string type, string condition, string belong)
        {
            string query = "UPDATE Spareparts SET Type = '" + type + "',Condition='" + condition + "',[Belonging_motorcycle_id]='" + belong + "' WHere [Spareparts_id]=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public object gettypes(string id)
        {
            string query = "Select Type from Spareparts Where Spareparts_ID=" + id;
            return (string)dbMan.ExecuteScalar(query);
        }
        public object getcondition(string id)
        {
            string query = "Select Condition from Spareparts Where Spareparts_ID=" + id;
            return (string)dbMan.ExecuteScalar(query);
        }
        public object getbelmoto(string id)
        {
            string query = "Select Belonging_motorcycle_id from Spareparts Where Spareparts_ID=" + id;
            return dbMan.ExecuteScalar(query).ToString();
        }
        //getters for acc update
        public int updateaccfunc(string id, string type, string size)
        {
            string query = "UPDATE Accessory SET Type = '" + type + "',Size='" + size + "' WHere [Accessory_id]=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
            public object gettypea(string id)
        {
            string query = "Select Type from Accessory Where Accessory_ID=" + id;
            return (string)dbMan.ExecuteScalar(query);
        }
        public object getsize(string id)
        {
            string query = "Select Size from Accessory Where Accessory_ID=" + id;
            return (string)dbMan.ExecuteScalar(query);
        }
    }
}
