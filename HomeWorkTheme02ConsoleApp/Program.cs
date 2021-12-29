using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTheme02ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Галимова Екатерина Валерьевна";
            string email = "katzhukova@gmail.com";

            byte age = 33;

            double programmingScores = 100;
            double mathScores = 50;
            double physicsScores = 30;

            Console.WriteLine($"ФИО: {fullName}; \nEmail: {email}; \nВозраст: {age}; " +
                $"\nБаллы по программированию: {programmingScores}; \nБаллы по математике: {mathScores}; \nБаллы по физике: {physicsScores}.");

            Console.ReadKey();

            double amountOfScores;

            amountOfScores = programmingScores + mathScores + physicsScores;

            double averageScore;

            averageScore = amountOfScores / 3;

            Console.WriteLine($"Сумма баллов по всем предметам:{amountOfScores}; \nСреднее арифметическое баллов: {averageScore}.");
        }
    }
}
