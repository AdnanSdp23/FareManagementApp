using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementApp.Model
{
    class VisitorZone
    {
        //public int Id { get; set; }
        public int Visitor_Id { get; set; }
        public string VisitorName { get; set; }
        public string VisitorEmail { get; set; }
        public string VisitorContactNumber { get; set; }
        public int Zone_Id { get; set; }
        public string ZoneName { get; set; }
    }
}
