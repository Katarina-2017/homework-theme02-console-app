using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Пространство имён
/// </summary>
namespace HomeWorkTheme02ConsoleApp
{
    /// <summary>
    /// Главная составляющая единица приложения - класс
    /// </summary>
    class Program
    {
        /// <summary>
        /// Код, который выполняется в первую очередь
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            string fullName = "Галимова Екатерина Валерьевна"; // создание строковых переменных fullName и email
            string email = "katzhukova@gmail.com";

            byte age = 33; //создание целочисленной переменной age (возраст явно не может превышать 225 лет)

            double programmingScores = 90; //создание переменных для хранения баллов, как постоянные числа с плавающей точкой
            double mathScores = 50;
            double physicsScores = 30;

            WriteLine($"ФИО: {fullName}; \nEmail: {email}; \nВозраст: {age}; " +
                $"\nБаллы по программированию: {programmingScores}; \nБаллы по математике: {mathScores}; \nБаллы по физике: {physicsScores}."); //форматированный вывод на экран

            ReadKey(); //задержка экрана

            double amountOfScores; //создание переменной для хранения суммы баллов, как постоянные числа с плавающей точкой

            amountOfScores = programmingScores + mathScores + physicsScores; //нахождение суммы баллов

            double averageScore; // создание переменной под средний балл, как постоянные числа с плавающей точкой

            averageScore = amountOfScores / 3; //нахождение среднего балла 

            WriteLine($"\nСумма баллов по всем предметам:{amountOfScores}; \nСреднее арифметическое баллов: {averageScore:#.##}."); //форматированный вывод на экран

            ReadKey(); //задержка экрана
        }
    }
}
