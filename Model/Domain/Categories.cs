using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace UIAssignmentRazorPages.Model.Domain
{
    public class Categories
    {
        public List<NorthwindCategory> GetCategories()
        {
            List<NorthwindCategory> categories = new List<NorthwindCategory>();
            const string dbConnectionString = "Server=dev1.baist.ca;Database=Northwind;User ID=userId;Password=****;TrustServerCertificate=True";
           
            SqlConnection dbConnection = new SqlConnection()
            {
                ConnectionString = dbConnectionString
            };
            dbConnection.Open();


            SqlCommand getShippersCommand = new SqlCommand()
            {
                Connection = dbConnection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "sramji2.uspGetNorthwindCategories"

            };
            SqlDataReader reader = getShippersCommand.ExecuteReader();

            while (reader.Read())
            {
                NorthwindCategory currentCategory = new NorthwindCategory();
                currentCategory.CategoryName = reader["CategoryName"].ToString();
                currentCategory.Description = reader["Description"].ToString();
                currentCategory.Picture = (byte[])reader["Picture"];

               


                categories.Add(currentCategory);
            }

            reader.Close();

            dbConnection.Close();

            return categories;
        }
    }
}
