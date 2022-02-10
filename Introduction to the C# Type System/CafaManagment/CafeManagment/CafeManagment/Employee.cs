using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagment
{
    public abstract class Employee
    {
        public const int taxRate = 15;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int HourlyRate { get; set; }
        public int WorkedHours { get; set; }
        public int Wage { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string surname, int hourlyRate)
        {
            Name = name;
            Surname = surname;
            HourlyRate = hourlyRate;
            Console.WriteLine($"Employee {Name} is registered.");
        }

        public void RegisterWorkedHours(int hours)
        {
            WorkedHours += hours;
            Console.WriteLine($"Employee {Name} added {hours} hours to his Worked Hours. Total Hours is {WorkedHours}");
        }

        public void PayWage()
        {
            Wage += HourlyRate * WorkedHours;

            Console.WriteLine($"Employee {Name} wage is {Wage}. It is added to your card.");

            WorkedHours = 0;
        }

        public void ChangeHourlyRate(int hourlyRate)
        {
            if(HourlyRate != hourlyRate)
            {
                HourlyRate = hourlyRate;
                Console.WriteLine($"Employee {Name} hourly rate changed to {hourlyRate}");
            }
            else
            {
                Console.WriteLine("Invalid hourly rate");
            }
            
        }

        public void AddBonus(int bonus)
        {
            Wage += bonus;

            Console.WriteLine("Bonus added");
        }

        public virtual void PerformWork()
        {
            Console.WriteLine("First");
        }
    }

    public class Manager : Employee
    {
        public Manager()
        {

        }

        public Manager(string name, string surname, int hourlyRate) : base(name, surname, hourlyRate) 
        {

        }

        public override void PerformWork()
        {
            Console.WriteLine("Second");
        }

        public override string ToString()
        {
            Console.WriteLine("hihihiih");
        }
    }
}
