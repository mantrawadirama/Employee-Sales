using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Logging
{
    public sealed class Logger
    {
        // This is Base version of Singleton.
        // code deosn't support multi-threaded aplication
        private static Logger instance = null;
        private static Logger GetInstance
        {
            get
            {
                if (instance == null)                
                    instance = new Logger();
                return instance;                
            }
        }
        private Logger()
        {

        }
    }
}
