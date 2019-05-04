using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj03
{
    class ShoretDiceDoubles
    {
        public static void Main(String[] args)
        {
            Random Generator = new Random();

            int numberOfAttempts = 0;
            int Roll1 = Generator.Next(6);
            int Roll2 = Generator.Next(6);

            do
            {

            
            Console.WriteLine("HERE COME THE DICE");

            Console.WriteLine("\nRoll #1: " + Roll1 + " ");
            Console.WriteLine("\nRoll #2: " + Roll2 + " ");

            } while (Roll1 != Roll2);
            {
                Roll1 = Generator.Next(1, 6);
                Roll2 = Generator.Next(1, 6);

                Console.WriteLine("\nRoll #1: " + Roll1 + " ");
                Console.WriteLine("\nRoll #2: " + Roll2 + " ");




                numberOfAttempts++;
            }
            int total = Roll1 + Roll2;

            Console.WriteLine("The total is: {0}", total);


            Console.ReadLine();
        }
    }

}
