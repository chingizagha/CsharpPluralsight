using System;
using System.Collections.Generic;

namespace WiredBrainCoffee.StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackStrings();
            StackDoubles();

            var tack = new Stack<double>;
            tack.

        }

        private static void StackStrings()
        {
            var stack = new SimpleStack<string>();

            stack.Push("Chingiz");
            stack.Push("Chingiz1");
            stack.Push("Chingiz2");

            string sum = "";

            while (stack.Count() > 0)
            {
                string item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += " " + item;
            }
            Console.WriteLine($"Sum: {sum}");
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack<double>();

            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;

            while (stack.Count() > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
