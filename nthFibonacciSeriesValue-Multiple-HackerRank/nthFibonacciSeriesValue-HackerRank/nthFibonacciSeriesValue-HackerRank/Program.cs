using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace nthFibonacciSeriesValue_HackerRank
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            long inp=0;
            string strInp = null;
            List<BigInteger> liInput = new List<BigInteger>();
            List<BigInteger> liOutput = new List<BigInteger>();
            do
            {
                strInp = Console.ReadLine();
                if (!string.IsNullOrEmpty(strInp))
                {
                    Int64.TryParse(strInp, out inp);
                    liInput.Add(inp);
                }
            } while (!string.IsNullOrEmpty(strInp));
            foreach (BigInteger n in liInput)
            {
                BigInteger FiboPrev = 1;
                BigInteger FiboPrevPrev = 0;
                BigInteger FiboSum = 0;
                if (n == 0)
                    FiboSum = 0;
                else if (n == 1)
                    FiboSum = 1;
                else
                    for (BigInteger i = 1; i < n; i++)
                    {
                        FiboSum = FiboPrev + FiboPrevPrev;
                        FiboPrevPrev = FiboPrev;
                        FiboPrev = FiboSum;
                    }
                liOutput.Add(FiboSum);
            }
            foreach (BigInteger num in liOutput)
            {

                Console.WriteLine(num);
            }

        }
        
    }
}
