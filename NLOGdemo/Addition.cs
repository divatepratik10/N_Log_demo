using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLOGdemo
{
    internal class Addition
    {
        public static Logger loggger = LogManager.GetCurrentClassLogger();
        public static void sum(int first, int second)
        {
            if(first <=0 || second <=0)
            {
                loggger.Warn("User inputs should not be 0 or Negative Numbers.");
                loggger.Error("User inputs should be Positive Numbers.");
            }
            else
            {
                int res = first + second;
                loggger.Info("Sum of two numbers is : " + res);
            }
        }
    }
}
