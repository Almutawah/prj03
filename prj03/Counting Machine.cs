using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj03
{
    class Counting_Machine
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Count from: ");
            int countFrom = int.Parse(Console.ReadLine());
            Console.WriteLine("Count to: ");
            int countTo = int.Parse(Console.ReadLine());
            Console.WriteLine("Count by: ");
            int countBy = int.Parse(Console.ReadLine());

            for (int i = 0; i <= countTo; i = i + countBy)
            {
                Console.WriteLine(i + " ");
        }
            Console.ReadLine();

        }
    }
}
