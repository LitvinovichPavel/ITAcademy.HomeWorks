using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace PilotProject
{
    public static class Logger
    {
        public static ILog Log = LogManager.GetLogger(typeof(Logger));

        public static void InitLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("Log.config"));
        }
    }
}
