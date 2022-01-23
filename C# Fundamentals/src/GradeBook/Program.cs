using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            //book.AddGrade(89.1);
            //book.AddGrade(55);
            //book.AddGrade(56);
            //book.AddGrade(55);
            //book.AddGrade(90);

            
            while(true)
            {
                Console.WriteLine("Please enter grade");
                var input = Console.ReadLine();

                if(input == "Q" || input == "q")
                {
                    break;
                }

                try
                {
                    var grade = Convert.ToDouble(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            try
            {
                Console.WriteLine("Enter book name");
                
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"The average {stats.Average:N3}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The grade letter is {stats.Letter}");
        }
    }
}
