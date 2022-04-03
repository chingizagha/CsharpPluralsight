using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Play();
            var b = new PlayWithMe();


            a.Name = "A";
            b.Name = "A";
            Console.WriteLine(a == b);
        }
    }

    internal class Play
    {
        public string Name { get; set; }
    }

    internal class PlayWithMe : Play
    {

    }

    internal record PlayRecord(string Name, string Surname);
}
