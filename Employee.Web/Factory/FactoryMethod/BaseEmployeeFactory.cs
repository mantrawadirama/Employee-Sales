using Employee.Web.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Web.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee.Web.Models.Employee _emp;
        public BaseEmployeeFactory(Employee.Web.Models.Employee emp)
        {
            _emp = emp;
        }
        public abstract IEmployeeManager Create();
        public Employee.Web.Models.Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetHourlyPay();
            return _emp;
        }
    }
}