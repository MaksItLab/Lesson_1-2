using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class Program
    {
        // class
        // struct
        // Конструктор и деструктор
        // Модификаторы доступа (Инкапсуляция)
        static void Main(string[] args)
        {
            #region Class
            //Person person1 = new Person("Maksim", "Kazan", 23);
            //person1.Print();

            //Console.WriteLine();

            //Person person2 = new Person("Ivan", "Moscow", 18);
            //person2.Print();

            //Person person3 = new Person(person2.name, person2.city, person2.age);

            //Console.WriteLine("После присвоения: ");
            //person2.Print();
            //person3.Print();

            //person3.name = "Petya";

            //Console.WriteLine("После изменения: ");
            //person2.Print();
            //person3.Print();
            #endregion

            //Human human1 = new Human("Maksim", "Kazan", 23);
            //human1.Study();

            
        }
    }

    public struct Human
    {
        public string name;
        public string city;
        public int age;


        public Human(string Name, string City, int Age)
        {
            name = Name;
            city = City;
            age = Age;
        }

        

        public void Study()
        {
            Console.WriteLine($"{name} учится, но в структуре");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{name}, {city}, {age}");
        }

    }

    public class Person
    {
        public string name;
        public string city;
        public int age;

        public Person(string Name, string City, int Age) 
        {
            name = Name;
            city = City;
            age = Age;
        }

        ~Person()
        {
            Console.WriteLine("Объект уничтожен");
        }

        public void Study()
        {
            Console.WriteLine($"{name} учится");
        }

        public void Print()
        {
            Console.WriteLine($"{name}, {city}, {age}");
        }

    }

    public class Car 
    {
        public class Engine
        {

        }
    }


}
