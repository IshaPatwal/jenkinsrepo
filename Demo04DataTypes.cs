using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Demo04DataTypes
    {
        static void Main(string[] args)
        {
            //Value types
            int x;
            x = 10;
            x = x + 20;
            Console.WriteLine(x);

            //Ref Types
            string str;
            str = "Anees Banu"; //1st mem loc
            Console.WriteLine(str); //Anees Banu

            str = "Saheera";    //1st mem loc will be deleted, 2nd one will be created
            Console.WriteLine(str); //Saheera

            str = str + " Banu";//2nd mem loc will be deleted, 3rd one will be created
            Console.WriteLine(str); //Saheera Banu

            Console.ReadKey();
        }
    }
}
