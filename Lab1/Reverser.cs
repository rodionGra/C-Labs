using System;
using System.Globalization;
using System.Threading;

namespace Lab1
{
    public static class Reverser
    {
        private static readonly char Separator = 
            Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        public static int Reverse(this int number)
        {
            var text = Convert.ToString(number);
            var result = ReverseInternal(text);
            return Convert.ToInt32(result);
        }

        public static string Reverse(this string text)
            => ReverseInternal(text);

        public static decimal Reverse(this decimal number)
        {
            var text = Convert.ToString(number, CultureInfo.CurrentCulture);
            var split = text.Split(Separator);
            split[0] = ReverseInternal(split[0]);
            split[1] = ReverseInternal(split[1]);

            var result = string.Join(Separator.ToString(), split);
            return Convert.ToDecimal(result);
        }

        public static void Reverse<T>(ref T[] arr)
        {
            for (var i = 0; i < arr.Length / 2; i++)
            {
                (arr[i], arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1], arr[i]);
            }
        }

        private static string ReverseInternal(string text)
        {
            var cArray = text.ToCharArray();
            var reverse = string.Empty;
            for (var i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            return reverse;
        }
    }
}