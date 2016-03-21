using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FibonacciModified_Hackerrank
{
    class Program
    {
        static BigInteger FNum;
        static BigInteger SNum;
        static void Main(string[] args)
        {
            
            BigInteger inp;
            string strInput=Console.ReadLine();
            BigInteger[] intInput = Array.ConvertAll(strInput.Split(' ').ToArray(), BigInteger.Parse);
            FNum = intInput[0];
            SNum = intInput[1];
            inp = intInput[2];
            if (inp >= 3 && inp <= 20 && FNum <= 2 && FNum >= 0 && SNum <= 2 && SNum >= 0)   
            Console.WriteLine(Fibonacci(inp-1));

        }
        public static BigInteger Fibonacci(BigInteger n)
        {
            if (n == 0)
                return FNum;
            else if (n == 1)
                return SNum;
            else
               // return (BigInteger)Math.Pow((Double)Fibonacci(n - 1), 2.0) + Fibonacci(n - 2);
                return (Fibonacci(n - 1) * Fibonacci(n - 1)) + Fibonacci(n - 2);
        }
    }
}
