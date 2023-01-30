using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Demo07Arrays
    {
        static void Main(string[] args)
        {
            //int sales[5]; in C,C++ lang
            //If a Company XYZ Pvt.Ltd - Branches 5 cities
            int[] sales = new int[5];

            //Input Area...
            Console.WriteLine("Enter sales amounts of 5 Branches of XYZ Pvt.Ltd");
            for (int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine("Enter for Branch {0}", i + 1);
                sales[i] = int.Parse(Console.ReadLine());
            }

            //Output Area...
            Console.WriteLine("Sales value of 5 Branches");
            for (int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine("Branch {0} sales amount {1}", (i + 1), sales[i]);
            }

            Console.ReadKey();
        }
    }
}
