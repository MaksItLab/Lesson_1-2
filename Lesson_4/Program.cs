﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    // 1. github
    // 2. массивы
    // 3. операции с массивами :
    //      a. инициализация массива
    //      б. вывод массива
    //      в. заполнение массива с клавиатуры
    //      г. вывод массива в обратном порядке
    //      д. найти сумму четных чисел массива
    //      е. найти наименьший элемент массива
    //      ё. найти индекс элемента
    // 4. вложенные циклы
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[10];
            //int[] array; // объявление
            //array = new int[10]; // инициализация
            //int[] array = new int[5] { 1, 2, 3, 4, 5 };
            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 ,8 };
            int[] array = { -1, 23, 10, 0, -4, 5, 9 };

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            


        }
    }

}
