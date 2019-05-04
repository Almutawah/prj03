using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Question 1: It will result in infinite loop.
//Question 2: the n won't have a value which won't let the program run.

namespace prj03
{
    class CountingFor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in a message, and I'll display it five times.");
            Console.Write("Message: ");
            string message = Console.ReadLine();

            for (int n = 2; n <= 10; n = n + 2)
            {
                Console.WriteLine(n + ". " + message);
            }
            Console.ReadLine();
        }
    }
}
