using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; int sum = 0;
            while (i <= 5)
            {

                sum += i;
                i++;
            }
            Console.WriteLine(" sum of five number is ={0}", sum);
            Console.ReadLine();
        }
    }
}
