using System;


namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;
            b += 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        private static void UsingStruct()
        {
            Employee employee;
            employee.Name = "Cingiz";
        }
    }

    


    struct Employee
    {
        public string Name;
            
    }
}
