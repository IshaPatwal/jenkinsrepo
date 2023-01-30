using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Demo05BoxingEx
    {
        static void Main(string[] args)
        {//Entry point

            object obj; //Ref.Type

            int i = 123;    //Val.Type
            obj = i;        // Boxing
            Console.WriteLine(obj); //123

            obj = "Rahul";   //Boxing
            Console.WriteLine(obj); //Rahul

            string name = (string)obj;  // Unboxing (ob ==> string)
            Console.WriteLine(name); //Rahul

            obj = 100;
            int j = (int)obj;  // Unboxing (ob => int)
            Console.WriteLine(j); //100

            obj = 'x';          //Single Char constant
            Console.WriteLine(obj); //x

            obj = 45.63f;       //Floating point value
            Console.WriteLine(obj); //46.63f

            Console.ReadKey();

        }//Exit point
    }
}
