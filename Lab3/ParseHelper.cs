using System;

namespace Lab3
{
    public static class ParseHelper
    {
        public static int InputParse(string message, string errorMessage)
        {
            bool isParsed;
            int result;

            do
            {
                Console.Write(message);
                isParsed = int.TryParse(Console.ReadLine(), out result);
                if (!isParsed)
                    Console.WriteLine(errorMessage);
            } while (!isParsed);

            return result;
        }
    }
}