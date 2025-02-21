using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    // зубчатые массивы
    // как устроена память, стек и куча
    // ref и out



    internal class Program
    {
        static void Main(string[] args)
        {

            #region Зубчатый массив

            //int[,] array2D = new int[3, 4]; // двумерный массив
            //int[] array1D = new int[5]; // одномерный массив
            //int[][] arrayToth = new int[3][]; // зубчатый массив

            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] array2 = { 1, 2 };
            //int[] array3 = { 1, 2, 3, 4, 5, 6, 7 };

            //arrayToth[0] = array1;
            //arrayToth[1] = array2;
            //arrayToth[2] = array3;

            //Console.WriteLine(arrayToth.Length);
            //Console.WriteLine(array2D.Length);

            //Console.WriteLine(arrayToth.Rank);
            //Console.WriteLine(array2D.Rank);

            //for(int i = 0; i < arrayToth.Length; i++)
            //{
            //    for(int j = 0; j < arrayToth[i].Length; j++)
            //    {
            //        Console.Write(arrayToth[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Память

            //int a = 8;
            //float f = 3.6f;
            //double d = 3.6;

            //Console.WriteLine(a);

            //Human person1; // объявили
            //person1 = new Human(); // проинициализировали

            //Func();
            #endregion
            #region ref и out

            //int num = 1;
            //Change(ref num);
            //Console.WriteLine(num);

            //int[] array = new int[]{ 1, 2, 3, 4, 5 };
            //Foo(ref array);

            //bool isNumber = int.TryParse("124.", out int result);

            //Console.WriteLine(result);
            //Console.WriteLine(isNumber);

            int a;

            Bar(out a);

            Console.WriteLine(a);

            #endregion
        }

        public static void Bar(out int number) 
        {
            number = 10;
        }

        public static void Foo(ref int[] arrayMethod)
        {
            arrayMethod = null;
        }
        public static void Change(ref int a)
        {
            a = 20;
        }
        public static void Func()
        {
            Func();
        }
    }

    public class Human
    {
        public string name;
    }

    public struct Man
    {

    }
}
