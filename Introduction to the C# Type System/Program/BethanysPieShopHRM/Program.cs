using System;


namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var num = Calculate(a: 5, b: 6);
            Console.WriteLine(num);
            static int Calculate(int a, int b) => a + b;
        }
    }
}
