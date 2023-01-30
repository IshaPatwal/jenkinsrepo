using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Demo06VerbatimLit
    {
        static void Main(string[] args)
        {
            string myfilelocation1 = "E:\\abc\\def\\ghi";
            Console.WriteLine(myfilelocation1);

            string myfilelocation2 = @"E:\abc\def\ghi";
            Console.WriteLine(myfilelocation2);

            Console.ReadKey();
        }
    }
}
