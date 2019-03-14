using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                    if (i == num)
                        Console.WriteLine("This is Prime!");
                    else
                    {
                        Console.WriteLine("This is NOT a prime!");
                        break;
                    }
                        
            }       
        }
    }
}
