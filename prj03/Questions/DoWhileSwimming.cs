using System;
using System.Threading;



//Question 1: Gallant and Goofus swim the same time.
//Question 2: Goofus swims for one minute while Gallant stops. 
//Question 3: Gallant check the temperature first.
//Question 4: Goofus also checks the temperature first.
//Question 5: do-while is to be excecuted at least once.

namespace prj03.Questions
{
    class DoWhileSwimming
    {
        public static void Main()
        {
            const int SLEEP_TIME = 1000;
            string swimmer1 = "GALLANT";
            string swimmer2 = "GOOFUS";

            double minimumTemperature = 79.0; // degrees Fahrenheit
            double currentTemperature;
            double savedTemperature;
            int swimTime;

            Console.Write("What is the current water temperature? ");

            currentTemperature = double.Parse(Console.ReadLine());
            savedTemperature = currentTemperature; // saves a copy of this value so we can get it back later.

            Console.WriteLine("\nOkay, so the current water temperature is " + currentTemperature + "F.");
            Console.WriteLine(swimmer1 + " approaches the lake....");

            swimTime = 0;
            while (currentTemperature >= minimumTemperature)
            {
                Console.Write("\t" + swimmer1 + " swims for a bit.");
                swimTime++;
                Console.WriteLine(" Swim time: " + swimTime + " min.");
                Thread.Sleep(SLEEP_TIME); // pauses for SLEEP_TIME milliseconds
                currentTemperature -= 0.5; // subtracts 1/2 a degree from the water temperature
                Console.WriteLine("\tThe current water temperature is now " + currentTemperature + "F.");
            }

            Console.WriteLine(swimmer1 + " stops swimming. Total swim time: " + swimTime + " min.");

            currentTemperature = savedTemperature; // restores original water temperature

            Console.WriteLine("\nOkay, so the current water temperature is " + currentTemperature + "F.");
            Console.WriteLine(swimmer2 + " approaches the lake....");

            swimTime = 0;
            do
            {
                Console.Write("\t" + swimmer2 + " swims for a bit.");
                swimTime++;
                Console.WriteLine(" Swim time: " + swimTime + " min.");
                Thread.Sleep(SLEEP_TIME);
                currentTemperature -= 0.5;
                Console.WriteLine("\tThe current water temperature is now " + currentTemperature + "F.");

            } while (currentTemperature >= minimumTemperature);

            Console.WriteLine(swimmer2 + " stops swimming. Total swim time: " + swimTime + " min.");
            Console.ReadLine();
        }

    }
}
