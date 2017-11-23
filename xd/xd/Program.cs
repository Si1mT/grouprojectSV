using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the first number:");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insert the second number");
            int y = Int32.Parse(Console.ReadLine());
            IEnumerable<int> range = Enumerable.Range(x, y);

            foreach (var result in range)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine(result + " is an even number");
                }
            }
            Console.ReadLine();
        }
    }
}
