using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp20
{
    internal class Program
    {
        //точка входа в программу
        static void Main(string[] args)
        {
            #region Lesson1

            //int a; //объявление переменной
            //a = 10; //инициализация

            //int number1 = int.Parse("314"); // Parse примнимает string
            //int number2 = Convert.ToInt32(true); // принимает любой тип данных
            //int number1 = int.Parse(Console.ReadLine()); // CTRL + D
            //int number2 = int.Parse(Console.ReadLine());


            //string name = "Nikita";
            //int age = 18;
            //string city = "Майкоп";

            //1. Конкатенация
            //Console.WriteLine("Ваше имя: " + name + ". Ваш город: " + city + ". Ваш возраст: " + age);
            //2. Форматинг строк. Плейсхолдеры
            //Console.WriteLine("Ваше имя: {0}. Ваш город: {1}. Ваш возраст: {2}", name, city, age);
            //3. Интерполяция строк
            //Console.WriteLine($"Ваше имя: {name}. Ваш город: {city}. Ваш возраст: {age}");

            #endregion

            // + сложение
            // - вычитание
            // / деление
            // * умножение
            // % остаток от деления

            //int num1 = int.Parse(Console.ReadLine()); // 4
            //int num2 = int.Parse(Console.ReadLine()); // 10

            //int resultSum = num1 + num2;
            //Console.WriteLine("Сумма: " + resultSum);

            //int resultSub = num1 - num2;
            //Console.WriteLine("Разница: " + resultSub);

            //double resultDiv = num1 / Convert.ToDouble(num2);
            //Console.WriteLine("Деление: " + resultDiv);

            //int resultMulti = num1 * num2;
            //Console.WriteLine("Умножение: " + resultMulti);

            //int resultPer = num1 % num2; //2 //2
            //Console.WriteLine(resultPer);

            Console.WriteLine("Введите сумму в $: ");
            double dollars = double.Parse(Console.ReadLine());
            double Rub = 97.9;
            double Yani = 7.27;

            double dollarsInRub = Rub * dollars;
            double dollarsInYani = Yani * dollars;

            Console.WriteLine($"{dollars}$ = {dollarsInRub}₽");
            Console.WriteLine($"{dollars}$ = {dollarsInYani}￥");

        }
    }
}
