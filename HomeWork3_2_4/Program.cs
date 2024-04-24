using HomeWork3_2_4;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var printerToAlex = new Invoice(123, "Alex", "ROZETKA");
printerToAlex.CalculatePrice("01924A", 12);

Console.WriteLine();

var paperToAnna = new Invoice(127, "Anna", "ROZETKA");
paperToAnna.CalculatePrice("11924A", 9);
