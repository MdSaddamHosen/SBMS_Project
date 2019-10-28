using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;


namespace SBMS.Repository
{

    public class SupplierRepository
    {
        string connectionString = @"Server=DESKTOP-Q5FQUO6; Database=SBMS; Integrated Security=True";

        public bool insertvalue(Suppliers suppliers)

        {
            bool isAdded = false;

 

            SqlConnection sqlConnection = new SqlConnection(connectionString);


            string Commandstring = @"INSERT INTO Suppliers VALUES('" + suppliers.Code + "','" + suppliers.Name + "','" + suppliers.Address + "','" + suppliers.Email + "', '" + suppliers.Contact + "','" + suppliers.ContactPerson + "')";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {

                isAdded = true;
            }
            sqlConnection.Close();


            return isAdded;
        }

        public bool IsCodeexist(Suppliers suppliers)
        {
            bool isFound = false;

            

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Suppliers WHERE Code='" + suppliers.Code + "' AND Id!='" + suppliers.Id + "' ";    //string thats why use ''


            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string code = sqlDataReader["Code"].ToString();
                isFound = true;
            }

            sqlConnection.Close();

            return isFound;
        }
        public bool IsEmailexist(Suppliers suppliers)
        {
            bool isFound = false;

            

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Suppliers WHERE Email='" + suppliers.Email + "' AND Id!='" + suppliers.Id + "' ";    //string thats why use ''


            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string Email = sqlDataReader["Email"].ToString();
                isFound = true;
            }

            sqlConnection.Close();

            return isFound;
        }
        public bool IsContactexist(Suppliers suppliers)
        {
            bool isFound = false;

            

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Suppliers WHERE Contact='" + suppliers.Contact + "' AND Id!='" + suppliers.Id + "' ";    //string thats why use ''


            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string Contact = sqlDataReader["Contact"].ToString();
                isFound = true;
            }

            sqlConnection.Close();

            return isFound;
        }

        public List<Suppliers> show()
        {
            List<Suppliers> lstsuppliers = new List<Suppliers>();
            

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Suppliers";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
             

            while (sqlDataReader.Read())
            {
                Suppliers suppliers = new Suppliers();

                suppliers.Id = Convert.ToInt32(sqlDataReader["Id"]);
                suppliers.Code = sqlDataReader["Code"].ToString();
                suppliers.Name = sqlDataReader["Name"].ToString();
                suppliers.Address = sqlDataReader["Address"].ToString();
                suppliers.Email = sqlDataReader["Email"].ToString();
                suppliers.Contact = sqlDataReader["Contact"].ToString();
                suppliers.ContactPerson = sqlDataReader["ContactPerson"].ToString();

                lstsuppliers.Add(suppliers);


            }
            sqlConnection.Close();

            return lstsuppliers;
        }
        public bool update(Suppliers suppliers)

        {
            bool isUpdate = false;

            
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"UPDATE Suppliers SET Code='" + suppliers.Code + "',Name='" + suppliers.Name + "',Address='" + suppliers.Address + "',Email='" + suppliers.Email + "',Contact='" + suppliers.Contact + "',ContactPerson='" + suppliers.ContactPerson + "' WHERE Id=" + suppliers.Id + "";


            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                isUpdate = true;
            }

            sqlConnection.Close();

            return isUpdate;
        }

        public bool delete(Suppliers suppliers)
        {
            bool isDelete = false;
 
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"DELETE FROM Suppliers WHERE Id=" + suppliers.Id + ";";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                isDelete = true;
            }

            sqlConnection.Close();

            return isDelete;
        }

        public List<Suppliers> Search(string name, string email, string contact)
        {
            List<Suppliers> lstsuppliers = new List<Suppliers>();
         

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT* FROM Suppliers WHERE Name = '" + name + "' OR Email='" + email + "' OR Contact='" + contact + "'";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                Suppliers suppliers = new Suppliers();

                suppliers.Id = Convert.ToInt32(sqlDataReader["Id"]);
                suppliers.Code = sqlDataReader["Code"].ToString();
                suppliers.Name = sqlDataReader["Name"].ToString();
                suppliers.Address = sqlDataReader["Address"].ToString();
                suppliers.Email = sqlDataReader["Email"].ToString();
                suppliers.Contact = sqlDataReader["Contact"].ToString();
                suppliers.ContactPerson = sqlDataReader["ContactPerson"].ToString();

                lstsuppliers.Add(suppliers);


            }
            sqlConnection.Close();

            return lstsuppliers;
        }

    }
}
