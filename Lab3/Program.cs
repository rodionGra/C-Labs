using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Reflection;

using static Lab3.ArrayInitializer;

namespace Lab3
{
    internal static class Program
    {
        // Task:
        // 2. Даний масив розміру N. Вивести спочатку його елементи з
        // парними(непарними) індексами, а потім — з непарними (парними). 

        public static void Main()
        {
            var arrSize = GetArraySize();
            var arr = GetArray(arrSize);
            Display(arr);
        }

        #region Display methods
        
        private static void Display(int[] arr)
        {
            if ((arr?.Length ?? 0) < 1)
            {
                Console.WriteLine("Null or empty array");
                return;
            }

            DisplayInternal(arr.Length);
        }
        
        private static void DisplayInternal(int upperBound)
        {
            // display unpaired numbers
            for (var i = 0; i < upperBound; i++)
            { 
                if(!IsPaired(i))
                    Console.Write($"{i} ");
            }

            Console.WriteLine();
            
            // display paired numbers
            for (var i = 0; i < upperBound; i+= 2)
            { 
                if(IsPaired(i))
                    Console.Write($"{i} ");
            }
        }

        private static bool IsPaired(this int i)
            => i % 2 == 0;

        #endregion
    }
}