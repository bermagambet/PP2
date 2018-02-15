using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int isPrime(int n) {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) 
                    return 0;
           
            }
            return 1;
        }
    static void Main(string[] args)
        {
            for ( int i = 0; i < args.Length; i++ )
            {
                if (isPrime(int.Parse(args[i])) == 1)
                    Console.WriteLine("Prime ");
                else
                    Console.WriteLine("Not Prime ");
            }
     
         Console.ReadKey();
        }
    }
}
