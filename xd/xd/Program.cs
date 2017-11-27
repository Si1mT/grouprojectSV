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
            string text = System.IO.File.ReadAllText("C:\\Users\\Siim\\Documents\\GitHub\\grouprojectSV\\kttekst.txt");
            //var result = text.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string[] trimmed = { text };
            string trimmed2 = trimmed.Trim();
            string[] text2= { };
            

            Console.WriteLine(text2);
            Console.ReadLine();


        }
    }
}
