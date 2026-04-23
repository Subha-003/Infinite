using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Product
{
    class ChartReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating Chart Report...");
        }
    }
}
