using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {




        public static double parallelepiped(double a, double b, double c)
        {
            double v = a*b*c;
            return v;
           
        }
        static void Main(string[] args)
        {   // Написать программу используя внешние методы
            // вычисляющую обьём прямоугольного параллелепипеда
            //программа должна запрашивать данные о пяти параллелепипедов

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("работа с параллелепидом №" + i);
                Console.WriteLine("введите сторону a");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите сторону b");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите сторону c");
                double c = Convert.ToDouble(Console.ReadLine());
                double otvet = parallelepiped(a, b, c);
                Console.WriteLine("ответ "+otvet);

            }
           
            Console.ReadKey();
        }
    }
}
