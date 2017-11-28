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
            char[] chars = { ' ', ',', '.', ':', };
            string text = System.IO.File.ReadAllText("C:\\Users\\opilane\\Documents\\GitHub\\grouprojectSV\\kttekst.txt");
            string[] myarray = text.Split(' ');
            int numberOfWords = myarray.Count();
            Console.WriteLine(numberOfWords);

            Console.ReadLine();

        }
    }
}
