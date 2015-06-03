using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.Model;
using FairManagementApp.DAL;

namespace FairManagementApp.BLL
{
    class VisitorManager
    {
       VisitorGateway aVisitorGateway = new VisitorGateway();
        public int SaveVisitor(Visitor aVisitor)
        {
            return aVisitorGateway.SaveVisitor(aVisitor);
        }
    }
}
