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
        private static Logger instance = null;
        private static readonly object obj = new object();
        // Property by which an instance can be created
        private static Logger GetInstance
        {
            get
            {
             // As lock is costly check for instance to be null again before entering lock. This is called double check lock
                if (instance == null)
                {
                    //lock will help us only 1 thread can enter at any given point
                    // if 2 controllers need to log lock will help until other action is compeleted
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Logger();
                    }
                }
                return instance;                
            }
        }
        // Restricted object creation 
        private Logger()
        {

        }
    }
}
