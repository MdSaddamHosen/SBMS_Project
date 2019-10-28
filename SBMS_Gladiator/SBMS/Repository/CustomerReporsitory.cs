using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using SBMS.Model;

namespace SBMS.Repository
{
   public class CustomerReporsitory
    {
        string connectionString = @"Server=DESKTOP-Q5FQUO6; Database=SBMS; Integrated Security=True";
        public bool insertvalue(Customers customers)

        {
            bool isAdded = false;


         

            SqlConnection sqlConnection = new SqlConnection(connectionString);


            string Commandstring = @"INSERT INTO Customer VALUES('" + customers.Code + "','" + customers.Name + "','" + customers.Address + "','" + customers.Email + "', '" + customers.Contact + "'," + customers.LoyltyPoint + ")";

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

        public bool IsCodeexist(Customers customers)
        {
            bool isFound = false;

           

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Customer WHERE Code='" + customers.Code + "' AND Id!='" + customers.Id + "' ";    //string thats why use ''


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
        public bool IsEmailexist(Customers customers)
        {
            bool isFound = false;

           

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Customer WHERE Email='" + customers.Email + "' AND Id!='" + customers.Id + "' ";    //string thats why use ''


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
        public bool IsContactexist(Customers customers)
        {
            bool isFound = false;

          
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Customer WHERE Contact='" + customers.Contact + "' AND Id!='" + customers.Id + "' ";    //string thats why use ''


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

        public List<Customers> show()
        {
            List<Customers> iscustomer = new List<Customers>();
            

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Customer";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            

            while (sqlDataReader.Read())
            {
                Customers customerse = new Customers();

                customerse.Id = Convert.ToInt32(sqlDataReader["Id"]);
                customerse.Code = sqlDataReader["Code"].ToString();
                customerse.Name = sqlDataReader["Name"].ToString();
                customerse.Address = sqlDataReader["Address"].ToString();
                customerse.Email = sqlDataReader["Email"].ToString();
                customerse.Contact = sqlDataReader["Contact"].ToString();
                customerse.LoyltyPoint =Convert.ToDouble(sqlDataReader["LoyltyPoint"]);

                iscustomer.Add(customerse);


            }
            sqlConnection.Close();

            return iscustomer;
        }
        public bool update(Customers customers)

        {
            bool isUpdate = false;

          
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"UPDATE Customer SET Code='" + customers.Code + "',Name='" + customers.Name + "',Address='" + customers.Address + "',Email='" + customers.Email + "',Contact='" + customers.Contact + "',LoyltyPoint='" + customers.LoyltyPoint + "' WHERE Id=" + customers.Id + "";


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

        public bool delete(Customers customers)
        {
            bool isDelete = false;

          
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"DELETE FROM Customer WHERE Id=" + customers.Id + ";";

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

        public List<Customers> Search(string name, string email, string contact)
        {
            List<Customers> iscustomers = new List<Customers>();
           
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Customer WHERE Name = '" + name + "' OR Email='" + email + "' OR Contact='" + contact + "'";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                Customers customerss = new Customers();

                customerss.Id = Convert.ToInt32(sqlDataReader["Id"]);
                customerss.Code = sqlDataReader["Code"].ToString();
                customerss.Name = sqlDataReader["Name"].ToString();
                customerss.Address = sqlDataReader["Address"].ToString();
                customerss.Email = sqlDataReader["Email"].ToString();
                customerss.Contact = sqlDataReader["Contact"].ToString();
                customerss.LoyltyPoint = Convert.ToDouble( sqlDataReader["LoyltyPoint"]);

                iscustomers.Add(customerss);


            }
            sqlConnection.Close();

            return iscustomers;
        }
    }
}
