using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace instrument.expert.web.Helpers
{
    public class LogHelper
    {
        public static void SetConfig()
        {
            XmlConfigurator.Configure();
        }

        public static void SetConfig(FileInfo config)
        {
            XmlConfigurator.Configure(config);
        }

        public static void WriteLog(string logstring, LogLevel level)
        {
            var type = MethodBase.GetCurrentMethod().DeclaringType;
            var m_log = LogManager.GetLogger(type);
            switch (level)
            {
                case LogLevel.Error:
                    if (m_log.IsErrorEnabled)
                        m_log.Error(logstring);
                    break;
                case LogLevel.Fatal:
                    if (m_log.IsFatalEnabled)
                        m_log.Fatal(logstring);
                    break;
                case LogLevel.Warn:
                    if (m_log.IsWarnEnabled)
                        m_log.Warn(logstring);
                    break;
                default:
                    break;
            }
        }

        public static void WriteLog(string logstring, Exception ex, LogLevel level)
        {
            var type = MethodBase.GetCurrentMethod().DeclaringType;
            var m_log = LogManager.GetLogger(type);
            switch (level)
            {
                case LogLevel.Error:
                    if (m_log.IsErrorEnabled)
                        m_log.Error(logstring, ex);
                    break;
                case LogLevel.Fatal:
                    if (m_log.IsFatalEnabled)
                        m_log.Fatal(logstring, ex);
                    break;
                case LogLevel.Warn:
                    if (m_log.IsWarnEnabled)
                        m_log.Warn(logstring, ex);
                    break;
                default:
                    break;
            }
        }
    }

    public enum LogLevel
    {
        Error,
        Fatal,
        Warn
    }
}