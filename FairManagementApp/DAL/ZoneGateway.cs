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
    class ZoneGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairConnectionString"].ConnectionString;
        public bool SaveAllZone(Zone aZone)
       
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_zone VALUES('" + aZone.ZoneName + "')";
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

        public List<Zone> GetAllZone()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM tbl_zone";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Zone> zoneList = new List<Zone>();
            while (sqlDataReader.Read())
            {
                Zone aZone = new Zone();
                aZone.Id = int.Parse(sqlDataReader["Id"].ToString());
                aZone.ZoneName = sqlDataReader["ZoneName"].ToString();
                zoneList.Add(aZone);
            }
            connection.Close();
            return zoneList;
        }
    }
}
