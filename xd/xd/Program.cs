using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace xd
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======
            char[] chars = { ' ', ',', '.', ':', };
            string text = System.IO.File.ReadAllText("C:\\Users\\Siim\\Documents\\GitHub\\grouprojectSV\\kttekst.txt");
            //var result = text.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string[] trimmed = { text };
            string trimmed2 = trimmed.Trim();
            string[] text2= { };
            

            Console.WriteLine(text2);
            Console.ReadLine();


>>>>>>> Harjutus2
        }
    }
}
