using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2_3 {
    internal class Employee {
        string firstname, lastname;

        public string FirstName { get { return firstname; } }

        public string LastName { get { return lastname; } }

        public bool IsDirector { get; set; }

        public string Position {
            get {
                return IsDirector ? "Директор" : "Звичайний працівник";
            }
        }

        public int WorkYears { get; set; }

        public Employee(string fname, string lname) {
            firstname = fname;
            lastname = lname;
        }

        public void ShowSalary() {
            var salary = IsDirector ? 23000 : 16000;
            if (WorkYears > 0) {
                salary += Convert.ToInt32(salary * WorkYears * 0.1);
            }

            var tax = Convert.ToInt32(salary * 0.05);

            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine(
                $"{firstname} {lastname}");

            Console.ForegroundColor = color;

            Console.WriteLine(
                $"Посада: {Position}\n" +
                $"Стаж: {WorkYears}р.\n" +
                $"З/П: {salary}грн.\n" +
                $"Податок: {tax}грн.");
        }
    }
}
