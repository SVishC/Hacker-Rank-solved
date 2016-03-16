using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mth_Number_from_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the numbers");
            int index = 0;
            long result = -1;
            Int32.TryParse(Console.ReadLine(), out index);
            bool go = true;
            string str_num = Console.ReadLine();
            object[] numbers = str_num.Split(' ');

            if (numbers.Length > 0 && numbers.Length > index && index > 0)
            {
                result = Convert.ToInt64(numbers[numbers.Length - index]);
            }
            if (index <= 0 || (index - numbers.Length) > 0)
            {
                go = false;
            }
            Console.WriteLine(go ? result.ToString() : "NIL");

            //Console.WriteLine(str);
        }
    }
}
