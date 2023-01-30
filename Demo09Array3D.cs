using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Demo09Array3D
    {
        static void Main(string[] anyName)
        {
            //2 Batches,3 Students,2 Subjects
            int[,,] a = new int[2, 3, 2];
            int bat, sd, sub;

            for (bat = 0; bat < 2; bat++)
            {
                Console.WriteLine("Details of Batch{0}", bat + 1);
                for (sd = 0; sd < 2; sd++)
                {
                    for (sub = 0; sub < 2; sub++)
                    {
                        Console.WriteLine("Enter mark{0} of student{1} of                                             batch{2}", sub + 1, sd + 1, bat + 1);
                        a[bat, sd, sub] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("Result Processed....");
            for (bat = 0; bat < 2; bat++)
            {
                Console.WriteLine("Batch{0}", bat + 1);
                for (sd = 0; sd < 2; sd++)
                {
                    Console.Write("Student{0}\t", sd + 1);
                    for (sub = 0; sub < 2; sub++)
                    {
                        Console.Write("{0}\t", a[bat, sd, sub]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
