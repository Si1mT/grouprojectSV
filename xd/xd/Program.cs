﻿using System;
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
         
            char[] chars = { ' ', ',', '.', ':', };
            string text = System.IO.File.ReadAllText("C:\\Users\\Siim\\Documents\\GitHub\\grouprojectSV\\kttekst.txt");
            //var result = text.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string[] trimmed = { text };
            string trimmed2 = trimmed.Trim();
            string[] text2= { };
            
            Console.WriteLine(text2);

            int[] values1 = { 11, 15, 6, 13, 13, 25, 32, 11, 20, 5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24 };
            int[] values2 = { 5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 7 };
            int[] same = values1.Intersect(values2).ToArray();
            int[] diff = values1.Union(values2).Except(same).ToArray();
            int[] c = new int[] { diff[0], same[0], same[1], diff[1] };
            Console.WriteLine(c);
            Console.ReadLine();
=======
            int[] values1 = {11, 15, 6, 13, 13, 25, 32, 11, 20, 5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24};
            int[] values2 = {5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 7};
            List<int> value1 = new List<int> { 11, 15, 6, 13, 13, 25, 32, 11, 20, 5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24 };
            List<int> value2 = new List<int> { 5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 7 };
            //string[] value3 = value1.Except(value2).ToArray();
            var max1 = value1.Max();
            var max2 = value2.Max();
            if (max1 < max2)
            {
                Console.WriteLine(max2);
            }
            if (max2 < max1)
            {
                Console.WriteLine(max1);
            }
>>>>>>> Harjutus-3

        }
    }
}
