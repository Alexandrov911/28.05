using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        //Написать внешнюю функцию расчета дискриминанта(запросить данные 3 раза)



        public static double discriminant(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            return d;

        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("работа с дискриминант №" + i);
                Console.WriteLine("введите  a");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите  b");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите c");
                double c = Convert.ToDouble(Console.ReadLine());
                double otvet = discriminant(a, b, c);
                Console.WriteLine("ответ " + otvet);

            }
            Console.ReadKey();
        }
    }
}
