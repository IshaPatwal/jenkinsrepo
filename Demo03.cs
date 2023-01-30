using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Demo03
    {
        public static void Main(string[] args)
        {
            //Student Registration
            Console.WriteLine("Enter student name");
            string Name = Console.ReadLine();

            Console.WriteLine("What degree you studying?");
            string DegreePrgm = Console.ReadLine();

            Console.WriteLine("What year you are studying? (1/2/3/4)");
            int acyear = int.Parse(Console.ReadLine());

            Console.WriteLine("What percentage you have? Ex: 83.54");
            float per = float.Parse(Console.ReadLine());

            Console.WriteLine("Name       {0}", Name);
            Console.WriteLine("Degree     {0}", DegreePrgm);
            Console.WriteLine("Year       {0}", acyear);
            Console.WriteLine("Percentage {0}", per);

            Console.WriteLine($"Name       {Name}");
            Console.WriteLine($"Degree     {DegreePrgm}");
            Console.WriteLine($"Year       {acyear}");
            Console.WriteLine($"Percentage {per}");

            Console.ReadKey();
        }
    }
}
