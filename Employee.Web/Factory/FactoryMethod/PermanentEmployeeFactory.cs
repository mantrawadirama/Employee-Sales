using Employee.Web.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Web.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory:BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee.Web.Models.Employee emp):base(emp)
        {

        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}