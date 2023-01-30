using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
   class Demo10JaggedArray
    {
        static void Main(string[] args)
        {
            int cand, elect;

            Console.WriteLine("Enter how many candidates (max 10)");
            int CandCount = int.Parse(Console.ReadLine());

            //A jagged array of n rows specified by CandCount
            int[][] ElectiveMarks = new int[CandCount][];


            for (cand = 0; cand < CandCount; cand++)
            {
                Console.WriteLine("How many electives for candidate                                                                   {0}", cand + 1);
                int electiveCount = int.Parse(Console.ReadLine());
                ElectiveMarks[cand] = new int[electiveCount];

                for (elect = 0; elect < electiveCount; elect++)
                {
                    Console.WriteLine("Enter elective {0} mark", elect + 1);
                    ElectiveMarks[cand][elect] = int.Parse(Console.ReadLine());
                }
            }

            // Output of each array element value
            for (cand = 0; cand < CandCount; cand++)
            {
                Console.WriteLine("Elective marks of candidate                                                                      {0}", cand + 1);
                for (elect = 0; elect < ElectiveMarks[cand].Length; elect++)
                {
                    Console.Write("{0}\t", ElectiveMarks[cand][elect]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
