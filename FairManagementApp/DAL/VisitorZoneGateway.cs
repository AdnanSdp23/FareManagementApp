using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.Model;

namespace FairManagementApp.DAL
{
    class VisitorZoneGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairConnectionString"].ConnectionString;
        public bool SaveVisitorZone(VisitorZone aVisitorZone)
        
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_visitorzone (Visitor_Id,Zone_Id) VALUES('" + aVisitorZone.Visitor_Id + "','" + aVisitorZone.Zone_Id + "')";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            int row = sqlCommand.ExecuteNonQuery();
            connection.Close();
            if (row == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<VisitorZone> SaveVisitorByZoneId(int zoneId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM VWvisitorzone WHERE Zone_Id='"+zoneId+"'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<VisitorZone> visitorZoneList = new List<VisitorZone>();
            while (sqlDataReader.Read())
            {
                VisitorZone visitorZone = new VisitorZone();
                visitorZone.Visitor_Id = int.Parse(sqlDataReader["Visitor_Id"].ToString());
                visitorZone.VisitorName = sqlDataReader["VisitorName"].ToString();
                visitorZone.VisitorEmail = sqlDataReader["VisitorEmail"].ToString();
                visitorZone.VisitorContactNumber = sqlDataReader["VisitorContactNumber"].ToString();
                visitorZone.Zone_Id = int.Parse(sqlDataReader["Zone_Id"].ToString());
                visitorZone.ZoneName = sqlDataReader["ZoneName"].ToString();
                visitorZoneList.Add(visitorZone);

            }
           
            connection.Close();
            return visitorZoneList;
        }
    }
}
