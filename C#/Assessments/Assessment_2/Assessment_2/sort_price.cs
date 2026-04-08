using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    class product
    {
        public int ProductId;
        public string ProductName;
        public double Price;

    }
    internal class sort_price
    {
        public static void Main()
        {
            List<product> list = new List<product>();
            for(int i = 0; i < 10; i++)
            {
                product p=new product();
                Console.Write("Enter Product ID: ");
                p.ProductId = int.Parse(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                p.ProductName = Console.ReadLine();

                Console.Write("Enter Price: ");
                p.Price = double.Parse(Console.ReadLine());
                list.Add(p);

            }
            var sort = list.OrderBy(p => p.Price);

            Console.WriteLine("-------Sorted Products by Price---------");
            foreach (var p in sort)
            {
                Console.WriteLine($"{p.ProductId} - {p.ProductName} - {p.Price}");
            }

        }
    }
}
