using System;
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
    // 4. операторы break(останавливает цикл) и continue(начинает следующую итерацию)
    // 5. двумерные массивы
    // 6. зубчатые массивы
    // 7. вложенные циклы
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            #endregion

            #region Инициализация
            //int[] array = new int[10];
            //int[] array; // объявление
            //array = new int[10]; // инициализация
            //int[] array = new int[5] { 1, 2, 3, 4, 5 };
            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 ,8 };
            #endregion
            #region Вывод массива
            //int[] array = { -1, 23, 10, 0, -4, 5, 9 };

            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Ввод с клавиатуры
            //int[] array = new int[10];
            //array = FillArray(array);
            //PrintArray(array);
            #endregion
            #region Вывод в обратном порядке
            //int[] array = new int[10];
            //array = FillArray(array);


            //for (int i = array.Length - 1; i >= 0;i--)
            //{
            //    Console.Write(array[i] + " ");
            //}

            #endregion
            #region Нахождение суммы четных элементов
            //int[] array = { 0, 2, 6, 3, 7, 5, 10, -12, 3, -11, 14 };

            //int sum = SumEvenNumbers(array);
            //Console.WriteLine("Сумма четных элементов: " + sum);
            #endregion
            #region Нахождение минимального элемента
            //int[] array = { 5, 12, 19, 101, 0, 12 };

            //int min = MinElement(array);
            //Console.WriteLine("Минимальный элемент: " + min);
            #endregion
            #region Нахождение индекса
            //int[] array = { 12, 2, 4, 5, 4, 5, 9, 3 };
            //int index = IndexOfElement(array, 12);
            //Console.WriteLine($"Индекс числа {12} = {index}");
            #endregion

            #region Двумерные массивы

            int[,] array = new int[,] {
                                            { 1, 2, 3, 4, 5 },
                                            { 1, 2, 3, 4, 5 },
                                            { 1, 2, 3, 4, 5 }
                                         };

            int[,] array2 = { 
                                { 1, 2, 3, 0 }, 
                                { 1, 2, 4, -4 },
                                { 1, 2, 4, -4 },
                                { 1, 2, 4, -4 },
                                { 1, 2, 4, -4 }
                            };

            for (int i = 0; i < array2.GetLength(0); i++) // перебирать массивы
            {
                for (int j = 0; j < array2.GetLength(1); j++) // перебирает элементы массива
                {
                    Console.Write(array2[i,j] + " ");
                }
                Console.WriteLine();
            }

            #endregion
        }

        public static int IndexOfElement(int[] array, int number)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] == number)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }


        public static int MinElement(int[] array)
        {
            int min = array[0]; // хранится минимальное значение

            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int SumEvenNumbers(int[] array)
        {
            int sum = 0;
            //int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                    //count++;
                }
            }

            return sum;
        }

        public static int[] FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }

}
