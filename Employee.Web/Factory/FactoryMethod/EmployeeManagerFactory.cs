using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Web.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee.Web.Models.Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if (emp.EmployeeTypeID ==1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if (emp.EmployeeTypeID == 2)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }
            return returnValue;

        }
    }
}