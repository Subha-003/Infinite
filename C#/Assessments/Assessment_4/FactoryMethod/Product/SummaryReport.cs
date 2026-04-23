using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Product
{
    class SummaryReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating Summary Report...");
        }
    }
}
