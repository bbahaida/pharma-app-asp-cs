using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain
{
    public class Log4NetHelper
    {
        private static ILog _logger;

        public static ILog GetLogger(Type type)
        {
            if (_logger != null)
                return _logger;
            XmlConfigurator.Configure();
            _logger = LogManager.GetLogger(type);
            return _logger;
        }
    }
}
