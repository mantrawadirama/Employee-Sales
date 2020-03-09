using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Logging
{
    //sealed class to avoid inheritence which also helps not to create more than 1 object
    public sealed class Logger
    {
        // This is Base version of Singleton.
        // code deosn't support multi-threaded aplication
        // private static Logger instance = null;
        // Eager loading
        // Lazy intialization with lazy keyword for > 4.0
        private static readonly Lazy<Logger> instance = new Lazy<Logger>(()=> new Logger());
        #region Below code is for < 4.0 framework for lazy initialization 
        //  private static readonly object obj = new object();
        // Property by which an instance can be created
        // As we are using property to cretae object this is called lazy initialization

        //private static Logger GetInstance
        //{
        //    get
        //    {
        //        // As lock is costly check for instance to be null again before entering lock. This is called double check lock
        //        if (instance == null)
        //        {
        //            //lock will help us only 1 thread can enter at any given point
        //            // if 2 controllers need to log lock will help until other action is compeleted
        //            lock (obj)
        //            {
        //                if (instance == null)
        //                    instance = new Logger();
        //            }
        //        }
        //        return instance;
        //    }
        //}
        #endregion
        private static Logger GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        // Restricted object creation 
        private Logger()
        {

        }
    }
}
