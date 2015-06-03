using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.Model;

namespace FairManagementApp.DAL
{
    class VisitorGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairConnectionString"].ConnectionString;
        public int SaveVisitor(Visitor aVisitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_visitor (Name,Email,ContactNumber) Output INSERTED.ID VALUES('" +
                           aVisitor.Name + "','" + aVisitor.Email + "','" + aVisitor.ContactNumber + "')";
            SqlCommand sqlCommand = new SqlCommand(query,connection);
            connection.Open();
            int id = (int) sqlCommand.ExecuteScalar();
            connection.Close();
            return id;

          
        }
    }
}
