using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nthFibonacciSeriesValue_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            long inp;
            Int64.TryParse(Console.ReadLine(), out inp);
            if(inp>=0)
            Console.WriteLine(Fibonacci(inp));

        }
        public static int Fibonacci(long n) 
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
