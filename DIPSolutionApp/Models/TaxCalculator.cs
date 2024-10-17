using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.Models
{
    class TaxCalculator
    {
        public ILogger logger;
        public TaxCalculator(ILogger logger1)
        {
            logger = logger1;

        }
        public int CalculateTax(int amount, int rate)
        {
            int Tax=0;
            try
            {
                Tax = amount / rate;
                Console.WriteLine("calculated tax is:"+Tax);
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message);
            }
            return Tax;
        }
    }
      
}
