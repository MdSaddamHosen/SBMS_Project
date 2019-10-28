using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SBMS.BLL;
using SBMS.Model;

namespace SBMS.Repository
{
    public class CategoryRepository
    {
        string connectionString = @"Server=DESKTOP-Q5FQUO6; Database=SBMS; Integrated Security=True";

        public bool insertvalue(Categories categories)

        {
            bool isAdded = false;


           

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            
            string Commandstring = @"INSERT INTO Category VALUES('" + categories.Code + "','" + categories.Name + "' )";

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

        public bool IsNameexist(Categories categories)
        {
            bool isFound = false;

           

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Category WHERE Name='" + categories.Name + "' AND Id!="+categories.Id+"";    //string thats why use ''


            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string code = sqlDataReader["Name"].ToString();
                isFound = true;
            }
            sqlConnection.Close();

            return isFound;
        }

        public bool IsCodeexist(Categories categories)
        {
            bool isFound = false;

           
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Category WHERE Code='" + categories.Code + "' AND Id!=" + categories.Id + "";    //string thats why use ''


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
        public List<Categories> show()
        {
            List<Categories> lstcategories = new List<Categories>();
            
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Category";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);

            
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Categories categories = new Categories();

                categories.Id = Convert.ToInt32(sqlDataReader["Id"]);
                categories.Code = sqlDataReader["Code"].ToString();
                categories.Name = sqlDataReader["Name"].ToString();
               

                lstcategories.Add(categories);


            }
            sqlConnection.Close();

            return lstcategories;
        }

        public bool update(Categories categories)

        {
            bool isUpdate = false;

           
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"UPDATE Category SET Code='" + categories.Code + "',Name='" + categories.Name + "' WHERE Id=" + categories.Id + "";


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

        public bool delete(Categories categories)
        {
            bool isDelete = false;

          

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"DELETE FROM Category WHERE Id=" + categories.Id + ";";

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

        public List<Categories> Search(string code,string name)
        {
            List<Categories> lstcategories = new List<Categories>();
           
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Category WHERE Code='" +code+"'  OR  Name='"+name+"'";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Categories categories = new Categories();
                categories.Id = Convert.ToInt32(sqlDataReader["Id"]);
                categories.Code = sqlDataReader["Code"].ToString();
                categories.Name = sqlDataReader["Name"].ToString();


                lstcategories.Add(categories);


            }
            sqlConnection.Close();

            return lstcategories;
        }
    }
}
