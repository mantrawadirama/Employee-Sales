using Employee.Web.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Web.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeID)
        {
            IEmployeeManager returnValue = null;
            if (employeeTypeID ==1)
            {
                returnValue = new PermanentEmployeeManager();
            }
            else if (employeeTypeID ==2)
            {
                returnValue = new ContractEmployeeManager();
            }
            return returnValue;
        }
    }
}