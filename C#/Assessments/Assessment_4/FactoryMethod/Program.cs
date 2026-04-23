using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Interfaces;
using FactoryMethod.Product;
using FactoryMethod.Factory;
namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter report type (Chart/Tabular/Summary): ");
            string input = Console.ReadLine();

            IReport report = ReportFactory.GetReport(input);
            report.Generate();
        }
    }
}
