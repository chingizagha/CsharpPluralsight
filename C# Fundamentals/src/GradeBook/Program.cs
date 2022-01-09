using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(55);
            book.AddGrade(56);
            book.AddGrade(55);
            book.AddGrade(90);

            var stats = book.GetStatistics();

            Console.WriteLine($"The average {stats.Average:N3}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            string y = "t";
            y = "ss";
            Console.WriteLine(y);
        }
    }
}
