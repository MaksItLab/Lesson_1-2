using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_2
{
    //метод -> класс -> namespace
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инкремент - операция прибавления 1
            // Декремент - операция вычитания 1

            //+,-,/,*,% бинарных
            //++,-- унарные

            int a = 10;
            a++; //постфиксный инкремент
            ++a; //префиксный инкремент
            a--; //постфиксный декремент
            --a; //префиксный декремент

            int b = 2;
            //Console.WriteLine(b);

            int result = b++ + --b - b-- - ++b;
            //2   +   2 - 2   -   2

            //Console.WriteLine(result);

            //2^10 = 1024

            int number = NumberPow(2,10);//вернет число

            Console.WriteLine(number);
        }

        public static int NumberPow(int number, int pow)
        {
            int result = Convert.ToInt32(Math.Pow(number, pow));
            return result;
        }
    }
}
