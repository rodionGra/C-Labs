using System;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Second quadrand - true is expected
            var point = new Point(-2, 7);
            Console.WriteLine(
                $"Is {point.ToString()} in second quadrant: {point.IsInSecondQuadrant()}");

            // Not in second quadrand - false is expected
            point = new Point(7, 7);
            Console.WriteLine(
                $"Is {point.ToString()} in second quadrant: {point.IsInSecondQuadrant()}");
        }
    }
}