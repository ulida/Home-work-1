using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number fгом the multiplicattion table");

            string number = Console.ReadLine();
            int j = Convert.ToInt32(number);

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{j}x{i} = {j * i}");
            }
            Console.ReadLine();
            
        }
    }
}


