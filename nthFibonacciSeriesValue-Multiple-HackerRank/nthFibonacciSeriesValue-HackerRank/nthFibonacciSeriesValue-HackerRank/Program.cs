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
            long inp=0;
            string strInp = null;
            List<long> liInput = new List<long>(); 
            List<long> liOutput = new List<long>();
            do
            {
                strInp = Console.ReadLine();
                if (!string.IsNullOrEmpty(strInp))
                {
                    Int64.TryParse(strInp, out inp);
                    liInput.Add(inp);
                }
            } while (!string.IsNullOrEmpty(strInp));
            foreach (long num in liInput)
            {
                liOutput.Add(Fibonacci(num));
            }
            foreach (long num in liOutput) {

                Console.WriteLine(num);
            }

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
