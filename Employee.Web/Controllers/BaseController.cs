using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.Logging;

namespace Employee.Web.Controllers
{
    public class BaseController : Controller
    {
        private ILog _log;
        public BaseController()
        {
            _log = Logger.GetInstance;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            _log.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}