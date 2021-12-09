using System;
using System.Collections.Generic;
using static Lab1.Reverser;

namespace Lab1
{
    internal static class Program
    {
        // Task:
        // Написати програму, що виконує наступні функції 
        // 1.	Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
        // 2.	Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)
        // 3.	Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)
        // 4.	Реалізувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)
        // 5.	Виконати пункт 4 з використанням ключових слів ref i out

        public static void Main()
        {
            #region reversed int

            const int intNumber = 321;
            Console.WriteLine(intNumber.Reverse());

            #endregion reversed int

            #region reversed string
            
            const string text = "ABC";
            Console.WriteLine(text.Reverse());
            
            #endregion

            #region reversed decimal number

            const decimal decimalNumber = 1234.5678m;
            Console.WriteLine(decimalNumber.Reverse());

            #endregion

            #region reversed array

            var arr = new[] {1, 2, 3, 4, 5};
            Console.WriteLine($"Array before reversing: {arr.DisplayResult()}");
            Reverse(ref arr);
            Console.WriteLine($"Array after reversing: {arr.DisplayResult()}");

            #endregion
        }
        
        private static string DisplayResult<T>(this IEnumerable<T> arr)
            => string.Join(" ", arr);
    }
}