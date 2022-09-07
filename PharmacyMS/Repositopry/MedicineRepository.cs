using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using PharmacyMS.Model;

namespace PharmacyMS.Repositopry
{
    public class MedicineRepository
    {
        public string connectionString = @"Server=DESKTOP-HNG1SPB\SQLEXPRESS; Database=PharmacyMS; Integrated Security=True";

        SqlConnection sqlConnection;
        private string commandString;
        private SqlCommand sqlCommand;
        SqlDataReader reader;

        public DataTable LoadCatagory()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Category";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
        public DataTable LoadCompany()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Company";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
        public DataTable LoadGenericName()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM GenericName";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
        public DataTable LoadDose()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Dose";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
        public DataTable Display()
        {

            //Connection
            string connectionString = @"Server=DESKTOP-HNG1SPB\SQLEXPRESS; Database=PharmacyMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            //Command 
            //string commandString = @"SELECT * FROM Medicine ";
            string commandString = @"select m.ID, m.Code,m.Name,ca.Name,co.Name,ge.Name,do.Name,ReorderLavel,AgeLimite,Country,m.Detail,Instruction from Medicine as m 
            left join Category as ca on ca.ID = m.CategoryId 
            left join Company as co on co.ID = m.CompanyId 
            left join GenericName as ge on ge.ID = m.GenericNameId
            left join Dose as do on do.ID = m.DoseId";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            //With DataAdapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //With DataAdapter
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //List<Customer> customers = new List<Customer>();

            //while (sqlDataReader.Read())
            //{
            //    Customer customer = new Customer();
            //    //District district = new District();
            //    customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
            //    customer.Code = sqlDataReader["Code"].ToString();
            //    customer.Name = sqlDataReader["Name"].ToString();
            //    customer.Address = sqlDataReader["Address"].ToString();
            //    customer.Contact = sqlDataReader["Contact"].ToString();
            //    customer.District_Id =Convert.ToInt32(sqlDataReader["District_Id"]);
            //    // district.Name = sqlDataReader["District_Name"].ToString();

            //    customers.Add(customer);
            //}
            //if (sqlDataReader.NextResult())
            //{
            //    while (sqlDataReader.Read())
            //    {
            //        District district = new District();
            //        district.Name = sqlDataReader["District_Name"].ToString();
            //        //customers.Add(district);       
            //    }
            //}

            //if (dataTable.Rows.Count > 0)
            //{

            //    //showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    //MessageBox.Show("No Data Found");
            //}

            //Close
            sqlConnection.Close();
            //return dataTable;
            return dataTable;

        }
        public DataTable allMedicineDisplay()
        {

            //Connection
            string connectionString = @"Server=DESKTOP-HNG1SPB\SQLEXPRESS; Database=PharmacyMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            //Command 
            string commandString = @"select m.ID Code,m.Name,ca.Name,co.Name,ge.Name,do.Name,ReorderLavel,AgeLimite,Country,m.Detail,Instruction from Medicine as m 
            left join Category as ca on ca.ID = m.CategoryId 
            left join Company as co on co.ID = m.CompanyId 
            left join GenericName as ge on ge.ID = m.GenericNameId
            left join Dose as do on do.ID = m.DoseId";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            //With DataAdapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //With DataAdapter
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //List<Customer> customers = new List<Customer>();

            //while (sqlDataReader.Read())
            //{
            //    Customer customer = new Customer();
            //    //District district = new District();
            //    customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
            //    customer.Code = sqlDataReader["Code"].ToString();
            //    customer.Name = sqlDataReader["Name"].ToString();
            //    customer.Address = sqlDataReader["Address"].ToString();
            //    customer.Contact = sqlDataReader["Contact"].ToString();
            //    customer.District_Id =Convert.ToInt32(sqlDataReader["District_Id"]);
            //    // district.Name = sqlDataReader["District_Name"].ToString();

            //    customers.Add(customer);
            //}
            //if (sqlDataReader.NextResult())
            //{
            //    while (sqlDataReader.Read())
            //    {
            //        District district = new District();
            //        district.Name = sqlDataReader["District_Name"].ToString();
            //        //customers.Add(district);       
            //    }
            //}

            //if (dataTable.Rows.Count > 0)
            //{

            //    //showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    //MessageBox.Show("No Data Found");
            //}

            //Close
            sqlConnection.Close();
            //return dataTable;
            return dataTable;

        }
        public bool Update(Medicine medicine)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-HNG1SPB\SQLEXPRESS; Database=PharmacyMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
               // commandString = "INSERT INTO Medicine(Code,Name,CategoryId,CompanyId,GenericNameId,DoseId,ReorderLavel,AgeLimite,Country,Detail,Instruction) VALUES ('" + medicine.Code + "','" + medicine.Name + "'," + medicine.CategoryId + "," + medicine.CompanyId + "," + medicine.GenericNameId + "," + medicine.DoseId + "," + medicine.ReorderLavel + ",'" + medicine.AgeLimite + "','" + medicine.Country + "','" + medicine.Detail + "','" + medicine.Instruction + "')";

                string commandString = @"UPDATE Medicine set Code='"+medicine.Code+"',Name='"+medicine.Name+"',CategoryId="+medicine.CategoryId+",CompanyId="+medicine.CompanyId+",GenericNameId="+medicine.GenericNameId+",DoseId="+medicine.DoseId+",ReorderLavel="+medicine.ReorderLavel+ ",AgeLimite='"+medicine.AgeLimite+ "',Country='"+medicine.Country+ "',Detail='"+medicine.Detail+"',Instruction='" + medicine.Instruction+"' WHERE ID="+medicine.ID+" ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return false;
        }
        public int addMedicine(Medicine medicine)
        {
            try
            {
                int isExecuted = 0;

                //commandString = "INSERT INTO Purchase (Date1,Invoice_No,Supplier_Id,Code) VALUES ('" + purchase.Date1 + "','" + purchase.InvoiceNo + "'," + purchase.Supplier_id + ",'" + purchase.Code + "')";
                commandString = "INSERT INTO Medicine(Code,Name,CategoryId,CompanyId,GenericNameId,DoseId,ReorderLavel,AgeLimite,Country,Detail,Instruction) VALUES ('" + medicine.Code + "','" + medicine.Name + "'," + medicine.CategoryId + "," + medicine.CompanyId + "," + medicine.GenericNameId + "," + medicine.DoseId + "," + medicine.ReorderLavel + ",'" + medicine.AgeLimite + "','" + medicine.Country + "','" + medicine.Detail + "','" + medicine.Instruction + "')";

                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                isExecuted = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                return isExecuted;
            }
            catch
            {
                //MessageBox.Show("Please re-check");
                int isExecuted = 0;
                return isExecuted;
            }
            
        }
        public bool IsCodeExists(Medicine medicine)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-HNG1SPB\SQLEXPRESS; Database=PharmacyMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Medicine WHERE Code='" + medicine.Code + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }
        public DataTable Search(Medicine medicine)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-HNG1SPB\SQLEXPRESS; Database=PharmacyMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 

            //string commandString = @"SELECT * FROM Medicine WHERE Name like '%" + medicine.Name + "%'";
            string commandString = @"select m.ID, m.Code,m.Name,ca.Name,co.Name,ge.Name,do.Name,ReorderLavel,AgeLimite,Country,m.Detail,Instruction from Medicine as m 
            left join Category as ca on ca.ID = m.CategoryId 
            left join Company as co on co.ID = m.CompanyId 
            left join GenericName as ge on ge.ID = m.GenericNameId
            left join Dose as do on do.ID = m.DoseId WHERE m.Name like '%" + medicine.Name + "%' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            //With DataAdapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();
            return dataTable;
        }
        public bool UpdateIsCodeExists(Medicine medicine)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-HNG1SPB\SQLEXPRESS; Database=PharmacyMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Medicine WHERE Code='" + medicine.Code + "' AND Id<>" + medicine.ID + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }
        public bool UpdateIsNameExists(Medicine medicine)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-HNG1SPB\SQLEXPRESS; Database=PharmacyMS; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Medicine WHERE Name='" + medicine.Name + "' AND Id<>" + medicine.ID + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }








    }
}
