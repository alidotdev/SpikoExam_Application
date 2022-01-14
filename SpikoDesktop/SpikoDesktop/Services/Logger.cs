using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//[assembly: log4net.Config.XmlConfigurator()]
namespace SpikoDesktop.Services
{
    class Logger
    {
        public  static readonly log4net.ILog log = log4net.LogManager.GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
