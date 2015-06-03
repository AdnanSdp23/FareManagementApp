using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    class VisitorZoneManager
    {
        VisitorZoneGateway aVisitorZoneGateway = new VisitorZoneGateway();
        public bool SaveVisitorZone(VisitorZone aVisitorZone)

        {
            return aVisitorZoneGateway.SaveVisitorZone(aVisitorZone);
        }

        public List<VisitorZone> SaveVisitorByZoneId(int zoneId)
        {
            return aVisitorZoneGateway.SaveVisitorByZoneId(zoneId);
        }
    }
}
