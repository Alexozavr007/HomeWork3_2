using HomeWork3_2_6;
using System.Globalization;
using System.Text;

Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-UA");
Console.OutputEncoding = Encoding.Unicode;

var R2D2 = new User(new DateTime(2024, 4, 22));
R2D2.Login = "bestrobot";
R2D2.Age = 1200;
R2D2.FirstName = "R2";
R2D2.LastName = "D2";
R2D2.OutputToScreen();

Console.WriteLine();

var Yoda = new User(new DateTime(1017, 6, 12));
Yoda.Login = "greenhead";
Yoda.Age = 1700;
Yoda.FirstName = "Minch";
Yoda.LastName = "Yoda";
Yoda.OutputToScreen();