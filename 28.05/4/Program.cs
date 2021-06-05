using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        //Написать внешнюю функцию нахождения факториала(основная программа запрашивает 4 числа)
        public static int factorial(int a)
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;
            }
            
            return f;

        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("введите a");
                int a = Convert.ToInt32(Console.ReadLine());
                int f = factorial(a);
                
                Console.WriteLine("f="+f);

            }
            Console.ReadKey();
        }
    }
}
