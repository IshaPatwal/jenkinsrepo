using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Demo08Array2D
    {
        static void Main(string[] args)
        {
            //Object initializer syntex....
            int[,] Marks = new int[5, 2] { { 72, 20 }, { 70, 21 }, { 60, 15 }, { 73, 16 }, { 64, 18 } };

            Console.WriteLine($"{"Name",-10}{"Internal",10}{"External",10}");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0,-10}", "Student" + (i + 1));
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0,10}", Marks[i, j]);
                }
                Console.WriteLine(); //writes empty line
            }

            Console.ReadKey();

            //Console.WriteLine($"{"Name",12}{"Internal",10}{"External",10}");
            //Console.WriteLine("===================================");

            //for (int i = 0; i < 5; i++)
            //{
            //    //student - 0,1,2,3,4
            //    Console.Write($"Student{i + 1:00}");
            //    for (int sub = 0; sub < 2; sub++)
            //    {
            //        Console.Write($"{Marks[i, sub],10}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("===================================");
            //Console.ReadKey();

        }
    }
}
