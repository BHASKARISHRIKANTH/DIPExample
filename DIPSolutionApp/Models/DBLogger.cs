using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.Models
{
    internal class DBLogger : ILogger
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine("error of DB logger"+errorMessage);
        }
    }
}
