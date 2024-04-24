using HomeWork3_2_2;

Console.OutputEncoding = System.Text.Encoding.Unicode;

var consoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Програма для конвертації валют");
Console.ForegroundColor = consoleColor;

Console.WriteLine("Натисніть одну з клавіш 1-6:");
Console.WriteLine("1 - Перевод з USD в гривню");
Console.WriteLine("2 - Перевод з EUR в гривню");
Console.WriteLine("3 - Перевод з GBP в гривню");
Console.WriteLine("4 - Перевод з гривні в USD");
Console.WriteLine("5 - Перевод з гривні в EUR");
Console.WriteLine("6 - Перевод з гривні в GBP");

// Курс валют станом на 4/20/2024
var converter = new Converter(
    usdPer1Hryvna: 0.0251714173521683, 
    eurPer1Hryvna: 0.0235897460092047, 
    gbpPer1Hryvna: 0.0203504344817762);

double hryvnaAmount;
bool continueWhile = true;
while (continueWhile) {
    Console.Write("\nВаш вибір: ");
    var userOption = Console.ReadLine();
    switch (userOption) {
        case "1":
            Console.Write("Введіть USD суму: ");
            double usdAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{usdAmount} USD = {converter.USD2Hryvna(usdAmount):0.00} грн.");
            break;
        
        case "2":
            Console.Write("Введіть EUR суму: ");
            double eurAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{eurAmount} EUR = {converter.EUR2Hryvna(eurAmount):0.00} грн.");
            break;

        case "3":
            Console.Write("Введіть GBP суму: ");
            double gbpAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{gbpAmount} GBP = {converter.GBP2Hryvna(gbpAmount):0.00} грн.");
            break;

        case "4":
            Console.Write("Введіть суму в гривнях: ");
            hryvnaAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{hryvnaAmount} грн. = {converter.Hryvna2USD(hryvnaAmount):0.00} USD");
            break;

        case "5":
            Console.Write("Введіть суму в гривнях: ");
            hryvnaAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{hryvnaAmount} грн. = {converter.Hryvna2EUR(hryvnaAmount):0.00} EUR");
            break;

        case "6":
            Console.Write("Введіть суму в гривнях: ");
            hryvnaAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{hryvnaAmount} грн. = {converter.Hryvna2GBP(hryvnaAmount):0.00} GBP");
            break;

        default: 
            continueWhile = false;
            break;
    }

}

