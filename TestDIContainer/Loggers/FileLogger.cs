using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDIContainer.Loggers;

namespace TestDIContainer
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.txt", message + Environment.NewLine);
        }
    }
}
