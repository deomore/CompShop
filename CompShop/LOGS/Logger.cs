using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net.Config;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace CompShop.LOGS
{
    public static class Logger
    {
        private static ILog log = LogManager.GetLogger("LOGGER");


        public static ILog Log
        {
            get { return log; }
        }

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
        

    }
}