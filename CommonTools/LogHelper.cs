using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    public static class LogHelper
    {
        public static readonly log4net.ILog logInfo = log4net.LogManager.GetLogger("logInfo");//这里的 loginfo 和 log4net.config 里的名字要一样
        public static readonly log4net.ILog logError = log4net.LogManager.GetLogger("logError");//这里的 logerror 和 log4net.config 里的名字要一样
        public static void WriteLogInfo(string msg)
        {
            if (logInfo.IsInfoEnabled)
            {
                logInfo.Info(msg);
            }
        }

        public static void WriteLogErr(string msg, Exception ex)
        {
            if (logError.IsErrorEnabled)
            {
                logError.Error(msg, ex);
            }
        }
    }

}

