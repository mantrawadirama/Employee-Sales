namespace Employee.Web.BusinessLogic
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetHourlyPay()
        {
            return 8;
        }
        public decimal GetHouseAllowance()
        {
            return 150;
        }
    }
}