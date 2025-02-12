using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Program
    {
        // Операции сравнения
        // Уловия
        // Логический операторы &,|,!
        // Проверка четности числа
        // Switch
        // Циклы (for, while, do while)

        static void Main(string[] args)
        {
            #region операции сравнения
            // >, <, >=, <=, ==, !=
            //int a = 10;
            //int b = 15;
            //Console.WriteLine(a == b); // false
            //Console.WriteLine(a > b); // false
            //Console.WriteLine(a < b); // true
            //Console.WriteLine(a >= b); // false
            //Console.WriteLine(a <= b); // true
            //Console.WriteLine(a != b); // true
            #endregion
            #region If
            //int a = 10;
            //int b = 10;


            //if (b > a)
            //{
            //    Console.WriteLine("b > a");
            //}
            //else if (a > b)
            //{
            //    Console.WriteLine("a > b");
            //}
            //else
            //{
            //    Console.WriteLine("a = b");
            //}
            #endregion
            #region Logic operator
            // And (Коньюнкция) - &&
            // Or (Дизъюнкция) - ||
            // Отрицание - !
            // & - в видео
            // | - в видео

            //bool one = true;
            //bool two = false;
            //bool isJump = false;

            //Console.WriteLine(one && two);  
            //Console.WriteLine(one || two);
            //Console.WriteLine(!one);
            //Console.WriteLine(!two);

            //if (!isJump)
            //{
            //    Console.WriteLine("Персонаж прыгнул!");
            //}
            //Console.WriteLine(two);

            #endregion
            #region EvenNumber
            //int a = 10;
            //int b = 30;
            //int count = 0;

            ////в цикле фор 3 раздела: инициализация;условие;действие
            //for(int i = a; i < b; i++) 
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Количество четных чисел: {count}");


            //while (count > -10) 
            //{
            //    Console.WriteLine(count);
            //    count--;
            //}

            //int c = -100;
            //do 
            //{ 
            //    Console.WriteLine("Hello World!");
            //    c--;
            //}
            //while (c > 0);

            #endregion

            // 3 -> три
            // 1 -> один
            // 10 -> десять

            int number = int.Parse(Console.ReadLine());
            char symbol = 'a';

            //switch

            switch (symbol)
            {
                case 'a':
                    Console.WriteLine("Один");
                    break;

                case 'b':
                    Console.WriteLine("Два");
                    break;

                case 'c':
                    Console.WriteLine("Три");
                    break;

                default:
                    Console.WriteLine("Неверное значение");
                    break;

            }

        }
    }
}
