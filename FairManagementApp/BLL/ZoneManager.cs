using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    class ZoneManager
    {
        ZoneGateway aZoneGateway = new ZoneGateway();
        public bool SaveAllZone(Zone aZone)
        {
            return aZoneGateway.SaveAllZone(aZone);
        }

        public List<Zone> GetAllZone()
        {
            return aZoneGateway.GetAllZone();
        }
    }
}
