using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Web.BusinessLogic
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetHourlyPay();
    }
}
