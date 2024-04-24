using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2_6 {
    internal class User {
        readonly DateTime recordDate;

        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime RecordDate {
            get {
                return recordDate;
            }
        }

        public User (DateTime recordDate) {
            this.recordDate = recordDate;
        }

        public void OutputToScreen() {
            var color  = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{FirstName} {LastName}");
            Console.ForegroundColor= color;
            Console.WriteLine($"Логін: {Login}");
            Console.WriteLine($"Вік: {Age}р.");
            Console.WriteLine($"Дата заповнення анкети: {recordDate:d MMMM yyyy}");
        }
    }
}
