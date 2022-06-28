using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("prints all odd numbers between 200 to 600");
            for (i = 200; i <= 600; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0} not divisible by 2", i);
                }
                else
                {
                    Console.WriteLine("{0} is divisible by 2", i);
                }
                Console.ReadLine();
            }
        }
    }
}
    


    
