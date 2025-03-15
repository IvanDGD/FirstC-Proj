using System;
using FirstC_Proj.GarbageCollection;
using FirstC_Proj.IInterfaces.IOutput;

namespace FirstC_Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //MyArray arr = new MyArray(10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //Console.WriteLine(arr.Greater(7));
            //Console.WriteLine(arr.Less(3));
            #endregion

            #region Task2
            //MyArray arr = new MyArray(10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //arr.ShowOdd();
            //arr.ShowEven();
            #endregion
            #region Task3
            //MyArray arr = new MyArray(10, 8, 8, 8, 8, 5, 8, 8, 8, 8, 8);
            //Console.WriteLine(arr.CountDistinct());
            //Console.WriteLine(arr.EqualToValue(5));
            #endregion
            #region Task4
            //Radio radio = new Radio();
            //radio.TurnOn();
            //radio.SetChannel(5);
            //radio.TurnOff();
            //radio.TurnOff();

            //TV tv = new TV();

            //tv.TurnOn();
            //tv.SetChannel(5);
            //tv.SetChannel(10);
            //tv.TurnOff();

            #endregion
            #region Task5
            //IValidator passwordValidator = new PasswordValidator();

            //string password = "1234567";
            //Console.WriteLine($"Password valid: {passwordValidator.Validate(password)}");

            //string password2 = "12345678";
            //Console.WriteLine($"Password valid: {passwordValidator.Validate(password2)}");

            #endregion
        }
    }
}