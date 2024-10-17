using DIPSolutionApp.Models;

namespace DIPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator t1 = new TaxCalculator(new DBLogger());
            t1.CalculateTax(1000, 2);
            TaxCalculator t2=new TaxCalculator(new FileLogger());
            t2.CalculateTax(100, 0);
        }
    }
}
