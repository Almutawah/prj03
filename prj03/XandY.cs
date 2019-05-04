using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj03
{
    class XandY
    {
       public static void Main(string[] args)
        {
            double x = 0.5;
            double y;
            

            Console.WriteLine("x          y");
            Console.WriteLine("---------------");

            
            for (double i = -10; i <= 10; i = i + x)
            {
                y = i * i;

                Console.WriteLine("{0,-5} {1,10}", i, y);

               
            }

            Console.ReadLine();
       
        }
    }
}
