using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Program
    {
        // Автосвойства и свойства
        // Оператор static 
        static void Main(string[] args)
        {
            //User user1 = new User("secret555bfbsdgbsfuigbsdfubgiudfbguysbgusdbgufsidbguidsbg");
            //Console.WriteLine(user1.Password); //получаем
            //user1.Password = "secret555"; //задаем
            //Console.WriteLine(user1.Password); //получаем
            //user1.Login = "login";
            //Console.WriteLine(user1.Login);

            //user1.GetPassword();

            //до:
            //Printer printer = new Printer();
            //printer.PrintStr("hello");

            //после:
            //Printer.PrintStr("hello");
            //Console.WriteLine(Printer.num);
            //Console.WriteLine(Printer.Dob);

            Enemy enemy1 = new Enemy();
            Enemy enemy2 = new Enemy();

            Console.WriteLine(nameof(enemy1));
            enemy1.Print();
            Console.WriteLine(nameof(enemy2));
            enemy2.Print();

            enemy2.health -= 20;

            Console.WriteLine("После изменения health");

            Console.WriteLine(nameof(enemy1));
            enemy1.Print();
            Console.WriteLine(nameof(enemy2));
            enemy2.Print();

            Enemy.max_health_static -= 50;

            Console.WriteLine("После изменения health_static");

            Console.WriteLine(nameof(enemy1));
            enemy1.Print();
            Console.WriteLine(nameof(enemy2));
            enemy2.Print();

            Enemy.CreateInstance();
            Enemy.CreateInstance();
            Enemy.CreateInstance();
            Enemy.CreateInstance();
            Enemy.CreateInstance();
            Enemy.CreateInstance();

            

        }

        public static void Rec()
        {
            Rec();
        }
    }

    public class User
    {
        private string _password; // поле

        public string Login { get; set; } // автосвойство

        public string Password // свойство
        {
            get
            {
                Console.WriteLine("Получаем значение пароль");
                return _password;
            }
            set
            {
                //if (value.Length > 21)
                //{
                //    Console.WriteLine("Пароль имеет длину больше 20 символов");
                //}
                //else
                //{
                //    _password = value;
                //    Console.WriteLine("Пароль был изменен");
                //}

                if (value.Length <= 20)
                {
                    _password = value;
                    Console.WriteLine("Пароль был изменен");
                    return;
                }
                Console.WriteLine("Пароль имеет длину больше 20 символов");
            }
        }

        public User(string password)
        {
            Password = password;
        }

        public string GetPassword() //выдает значение
        {
            return Password;
        }

        public void SetPassword(string password) //задает значение
        {
            Password = password;
        }
    }


    public class Printer
    {
        public static int num = 10;

        public static double Dob { get; set; } = 3.14;
        public static void PrintStr(string str)
        {
            Console.WriteLine(str);
        }

        public Printer(int number)
        {
            num = number;
        }

        public void SetNum(int number)
        {
            num = number;
        }
    }


    public class Enemy
    {
        public static int max_health_static = 1000; // статичекое поле(переменная)

        public int health = max_health_static; //  НЕ статичекое поле(переменная)

        public static string Name { get; set; } = "Enemy";// статичекое свойство
        public double Damage { get; set; } = 10.0;// Не статичекое свойство

        public void Print() // НЕ статический метод
        {
            Console.WriteLine(nameof(max_health_static) + " " + max_health_static);
            Console.WriteLine(nameof(health) + " " + health);
        }

        public static void CreateInstance() // статический метод
        {
            Console.WriteLine("Противник создан");
        }
    }

    public static class EnemyStatic // статический класс
    {
        public static void Print()
        {

        }
    }
}
