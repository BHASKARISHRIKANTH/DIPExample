using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LLM
{
    internal class DBLogger
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine("error logged to DB" + errorMessage);
        }
    }
}
