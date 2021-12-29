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

            Console.WriteLine($"/t ФИО: {fullName}; /t Email: {email}; /t Возраст: {age}; " +
                $"/t Баллы по программированию: {programmingScores}; /t Баллы по математике: {mathScores}; /t Баллы по физике: {physicsScores}");

            
        }
    }
}
