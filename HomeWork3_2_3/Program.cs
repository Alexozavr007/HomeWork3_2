using HomeWork3_2_3;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var me = new Employee("Alex", "Kondratiuk");
me.IsDirector = true;
me.WorkYears = 10;
me.ShowSalary();
Console.WriteLine();

var bogdan = new Employee("Bogdan", "Pipirka");
bogdan.IsDirector = false;
bogdan.WorkYears = 2;
bogdan.ShowSalary();