using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDIContainer.Loggers;

namespace TestDIContainer
{
    internal class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Логіка для запису повідомлення в базу даних
        }
    }
}
