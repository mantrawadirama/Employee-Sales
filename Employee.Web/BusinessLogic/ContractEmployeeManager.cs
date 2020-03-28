using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Web.BusinessLogic
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetHourlyPay()
        {
            return 12;
        }
        public decimal GetMedicalAllowance()
        {
            return 100;
        }
    }
}