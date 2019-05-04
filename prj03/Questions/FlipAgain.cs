using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Question 3: the program won't run because the variable doesn't have a value.

namespace prj03.Questions
{
    class FlipAgain
    {
        
        public static void Main(String[] args)
        {
            Random rng = new Random();

            string again = "y";

            while (again.Equals("y"))
            {
                int flip = rng.Next(2);
                String coin;

                if (flip == 1)
                {
                    coin = "HEADS";
                }
                else
                {
                    coin = "TAILS";
                }

                Console.WriteLine("You flip a coin and it is... " + coin);

                Console.Write("Would you like to flip again (y/n)? ");
                again = Console.ReadLine();
            }
            Console.ReadLine();
        }
        

    }
}
