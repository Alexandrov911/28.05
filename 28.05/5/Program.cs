using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        public static int Sum(int a)
        {
            //в программе вызвать ее 5 раз с различными данными
            int k = 0;
            while (a != 0)
            {
               int m = a % 10;
                k = k + m;
                a = a / 10;

            }
            return k;
        }
        static void Main(string[] args)
        {
          
            Console.WriteLine(Sum(4390934));
            Console.ReadKey();
        }
    }
}
