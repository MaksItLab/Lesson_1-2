using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class Program
    {
        // List<T>
        // Dictionary<TKey, TValue>
        // Stack<T>
        // Queue<T>
        static void Main(string[] args)
        {
            #region List


            //List<int> list = new List<int>();
            //list.Add(52);
            //list.Add(3);
            //list.Add(-23);
            //list.Add(0);

            //for (int i = 0; i < list.Count; i++) 
            //{
            //    Console.Write(list[i] + " ");
            //}

            //Print(list);

            //list.AddRange(new int[] { 1, 2, 3, 45, 7 });

            //Print(list);

            //Console.WriteLine(list.Count);

            //bool isRemoved = list.Remove(3);

            //Print(list);

            //Console.WriteLine(isRemoved);

            //list.RemoveAt(1);

            //Print(list);

            //list.Clear(); // очистит весь список
            //Console.WriteLine(list.Contains(1000)); 
            //list.Insert(3, 1000); //вставка элемента в определенный индекс

            //Print(list);
            #endregion

            Dictionary<int, string> priority = new Dictionary<int, string>();
            priority.Add(0,"Низкий");
            priority.Add(1,"Между низким и средним");
            priority.Add(2,"Средний");
            priority.Add(3,"Между средним и высоким");
            priority.Add(4,"Высокий");

            //priority.TryGetValue(3, out string result);

            //Console.WriteLine("Приоритет задачи: " + result);

            foreach (var item in priority.Keys)
            {
                Console.WriteLine(priority[item]);
            }

        }

        public static void Print(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
