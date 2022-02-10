using System;
using System.Collections.Generic;

namespace CafeManagment
{
    internal class Program
    {
        private static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            object o1 = new Manager();
            

            void Generate()
            {
                Console.WriteLine("hahahha");
            }
            string selected;
            
            do
            {
                Console.WriteLine("*********************\n* Select an action *\n*********************");
                Console.WriteLine("1: Register employee\n2: Register work hours for employee\n3: Pay employee\n4: Change hourly rate\n5: Give bonus\n9: Quit");
                selected = Console.ReadLine();

                switch (selected)
                {
                    case "1":
                        RegisterEmployee();
                        break;
                    case "2":
                        RegisterHours();
                        break;
                    case "3":
                        Pay();
                        break;
                    case "4":
                        HourlyRate();
                        break;
                    case "5":
                        GiveBonus();
                        break;
                    case "9":
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }

            }while (selected != "9");
        }

        private static void GiveBonus()
        {
            Console.WriteLine("Choose the employee");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {employees[i].Surname} {employees[i].Name}");
            }
            int selectedEmp = Convert.ToInt32(Console.ReadLine());
            Employee selected = employees[selectedEmp - 1];
            Console.WriteLine("Write bonus");
            int bonus = Convert.ToInt32(Console.ReadLine());
            selected.AddBonus(bonus);
        }

        private static void HourlyRate()
        {
            Console.WriteLine("Choose the employee");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {employees[i].Surname} {employees[i].Name}");
            }
            int selectedEmp = Convert.ToInt32(Console.ReadLine());
            Employee selected = employees[selectedEmp - 1];
            Console.WriteLine($"Employee {selected.Name} hourly rate is {selected.HourlyRate}.\nPlease add new hourly rate");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            selected.ChangeHourlyRate(hourlyRate);
        }

        private static void RegisterEmployee()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter the hourly rate");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());

            //Employee employee = new Employee(name, surname, hourlyRate);
            //employees.Add(employee);
            //Console.WriteLine("Employee added");
        }
        private static void RegisterHours()
        {
            Console.WriteLine("Choose the employee");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{i+1}. {employees[i].Surname} {employees[i].Name}");
            }

            int selectedEmp = Convert.ToInt32(Console.ReadLine());
            Employee selected = employees[selectedEmp - 1];
            Console.WriteLine("Add worked hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            selected.RegisterWorkedHours(hours);
        }

        private static void Pay()
        {
            Console.WriteLine("Choose the employee");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {employees[i].Surname} {employees[i].Name}");
            }

            int selectedEmp = Convert.ToInt32(Console.ReadLine());
            Employee selected = employees[selectedEmp - 1];

            selected.PayWage();
        }


        
    }
}
