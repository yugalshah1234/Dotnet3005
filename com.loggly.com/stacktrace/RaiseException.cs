using System;

using System.IO;
using System.Reflection;
using log4net;

namespace dotnetcore_stacktrace
{
    class RaiseException
    {

        public RaiseException(String exceptionMessage)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            log4net.Config.XmlConfigurator.Configure(logRepository, new FileInfo("App.config"));
            var logger = LogManager.GetLogger(typeof(RaiseException));
            RaiseMultiLineException(exceptionMessage, logger);
        }

        private void RaiseMultiLineException(String exceptionMessage, ILog logger)
        {
            try
            {
                getException4(exceptionMessage);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
            }
        }
        private void getException4(String exceptionMessage)
        {
            getException3(exceptionMessage);
        }
        private void getException3(String exceptionMessage)
        {
            getException2(exceptionMessage);
        }
        private void getException2(String exceptionMessage)
        {
            getException1(exceptionMessage);
        }
        private void getException1(String exceptionMessage)
        {
            getException(exceptionMessage);
        }
        private void getException(String exceptionMessage)
        {
			if (!String.IsNullOrEmpty(exceptionMessage)) 
			{
            	throw new Exception(exceptionMessage);
			}
            int a = 10, b = 0;
            a = a / b;
        }
    }
}
