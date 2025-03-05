using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Модификаторы доступа


            //Модификаторы доступа:
            // private - доступен только внутри класса
            // protected - доступен только внутри класса и классов-наследников
            // internal - доступен только в текущем проекте
            // public - доступен в любом месте
            //Account user = Account.CreateObject("maksim", "second", 233);
            //string login = Console.ReadLine();
            //string password = Console.ReadLine();
            //FileName fileName = new FileName();

            

            //if (login.Equals(user.GetLogin()) && password.Equals(user.GetPassword()))
            //{
            //    Console.WriteLine("Успешный вход");
            //}
            //else
            //{
            //    Console.WriteLine("Данные некорректные");
            //}

            #endregion

            #region
            #endregion

            #region Деструкторы
            //GC(Garbage Collector) - сборщик мусора
            Account account1 = new Account("Maksim", "Lastname", 23);
            Account account2 = new Account("Maksim", "Lastname", 23);
            Account account3 = new Account("Maksim", "Lastname", 23);
            Account account4 = new Account("Maksim", "Lastname", 23);
            Account account5 = new Account("Maksim", "Lastname", 23);
            Account account6 = new Account("Maksim", "Lastname", 23);

            account1 = null;
            GC.Collect();//процесс продолжительный
            GC.WaitForPendingFinalizers();//метод остановит программу,
                                          //пока не будут удалены объекты

            // 1 поколение - это только созданные объекты
            // 2 поколение - это недавно созданные объекты, которыми пользуется программа
            // 3 поколение - это самые старые объекты
            #endregion
        }
    }

    public class Account
    {
        //public static Account account;
        private string _name;
        private string _lastName;
        private int _age;

        private string _login = "unity123";
        private string _password = "secret999";

        public Account(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        ~Account()
        {
            Console.WriteLine("Объект уничтожен");
        }

        //public static Account CreateObject(string name, string lastName, int age)
        //{
        //    account = new Account(name, lastName, age);
        //    return account;
        //}

        public string GetPassword()
        {
            return password;
        }

        public string GetLogin()
        {
            return login;
        }

        
    }
}
