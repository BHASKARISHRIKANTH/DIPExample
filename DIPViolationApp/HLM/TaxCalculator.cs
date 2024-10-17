using DIPViolationApp.LLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.HLM
{
    internal class TaxCalculator
    {
        private DBLogger logger;
        public TaxCalculator()
        {
            logger = new DBLogger();
        }
        public int CalculateTax(int amount,int rate)
        {
            int Tax = 0;
            try
            {
                Tax = amount / rate;
            }
            catch(Exception ex){
                logger.Log(ex.Message);
                 }
            return Tax;


        }

    }
}
