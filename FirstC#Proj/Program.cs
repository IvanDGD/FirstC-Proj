using System;
using System.Globalization;

namespace FirstC_Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //Employee emp1 = new Employee(5000);
            //Employee emp2 = new Employee(7000);
            //Employee emp3 = new Employee(5000);

            //Console.WriteLine(emp1);
            //Console.WriteLine(emp2);

            //Console.WriteLine(emp1 + 2000);
            //Console.WriteLine(emp2 - 1000);

            //Console.WriteLine(emp1 == emp3);
            //Console.WriteLine(emp1 != emp2);
            //Console.WriteLine(emp1 > emp2);
            //Console.WriteLine(emp2 > emp1);
            //Console.WriteLine(emp1 < emp3);

            #endregion

            #region Task2

            //Matrix matrix = new Matrix(5, 5);
            //Matrix matrix2 = new Matrix(5, 5);

            //Matrix matrix3 = matrix + matrix2;

            //Console.WriteLine(matrix);
            //Console.WriteLine(matrix2);
            //Console.WriteLine(matrix3);

            //Console.WriteLine(matrix + matrix2);
            //Console.WriteLine(matrix - matrix2);

            //Console.WriteLine(matrix == matrix2);
            //Console.WriteLine(matrix != matrix2);

            #endregion

            #region Task3

            //City popul1 = new City(100000);
            //City popul2 = new City(70000);
            //City popul3 = new City(500000);

            //Console.WriteLine(popul1);
            //Console.WriteLine(popul2);

            //Console.WriteLine(popul1 + 2000);
            //Console.WriteLine(popul2 - 1000);

            //Console.WriteLine(popul1 == popul3);
            //Console.WriteLine(popul1 != popul2);
            //Console.WriteLine(popul1 > popul2);
            //Console.WriteLine(popul2 > popul1);
            //Console.WriteLine(popul1 < popul3);

            #endregion

            #region Task4

            //CreditCard card1 = new CreditCard(100, 838);
            //CreditCard card2 = new CreditCard(1000, 749);
            //CreditCard card3 = new CreditCard(315, 194);

            //Console.WriteLine(card1);
            //Console.WriteLine(card2);

            //Console.WriteLine(card1 + 2000);
            //Console.WriteLine(card2 - 1000);

            //Console.WriteLine(card1 == card3);
            //Console.WriteLine(card1 > card2);
            //Console.WriteLine(card2 > card1);
            //Console.WriteLine(card1 < card3);

            #endregion

            #region Task5

            //Currency usd = new Currency("USD", 1.0);
            //Currency eur = new Currency("EUR", 0.92);
            //Currency gbp = new Currency("GBP", 0.78);

            //double usdAmount = 100; 
            //double eurAmount = usdAmount * eur; 
            //double gbpAmount = usdAmount * gbp; 

            //Console.WriteLine($"{usdAmount} USD = {eurAmount} EUR");
            //Console.WriteLine($"{usdAmount} USD = {gbpAmount} GBP");

            //double backToUsd = eurAmount / eur;
            //Console.WriteLine($"{eurAmount} EUR = {backToUsd} USD");

            #endregion

            #region Task6

            Player player = new Player("Player");

            player.Score = 5;
            Console.WriteLine($"Score: {player.Score}, Level: {player.Level}");

            player.Score = 10;
            Console.WriteLine($"Score: {player.Score}, Level: {player.Level}");

            #endregion

        }


    }
}
