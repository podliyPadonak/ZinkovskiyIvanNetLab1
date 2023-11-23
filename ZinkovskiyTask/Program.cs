using System;
using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;
Console.WriteLine("РОБОТА ЗІНКОВСЬКОГО ІВАНА, ОНЛАЙН ГРУПА");

while (true)
{
    Console.WriteLine("\nВиберіть, що обчислювати:\n1 - Площа паралелограма" +
    "\n2 - Площа трикутника за форммулою Герона" +
    "\n3 - Площа бічної поверхні правильної піраміди" +
    "\n4 - Об'єм правильної чотирикутної піраміди" +
    "\n5 - Об'єм сфери\n");

    Console.Write("Ваша відповідь:");
    string option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.WriteLine("\nВи вибрали площу паралелограма");
            double x = getNumericFromConsole("Уведіть x(довжину сторони):");
            double h = getNumericFromConsole("Уведіть h(висоту):");
            Console.Write($"Площа такого паралелограма дорівнює: {x * h}\nНатисніть Enter щоб продовжити...");
            Console.ReadLine();
            break;
        case "2":
            Console.WriteLine("\nВи вибрали площу трикутника за формулою Герона");
            double a = getNumericFromConsole("Уведіть довжину сторони а:");
            double b = getNumericFromConsole("Уведіть довжину сторони b:");
            double c = getNumericFromConsole("Уведіть довжину сторони c:");
            Console.Write($"Площа такого трикутника дорівнює: {calculateAreaOfATriangleByHeron(a, b, c)}\nНатисніть Enter щоб продовжити...");
            Console.ReadLine();
            break;
        case "3":
            Console.WriteLine("\nВи вибрали площу бічної поверхні правильної піраміди");
            double p = getNumericFromConsole("Уведіть периметр основи піраміди:");
            double apofema = getNumericFromConsole("Уведіть довжину апофеми піраміди:");
            Console.Write($"Площа бічної поверхні такої піраміди дорівнює: {p * apofema / 2F}\nНатисніть Enter щоб продовжити...");
            Console.ReadLine();
            break;
        case "4":
            Console.WriteLine("\nВи вибрали об'єм правильної чотирикутної піраміди");
            double aWidth = getNumericFromConsole("Уведіть довжину сторони основи:");
            double height = getNumericFromConsole("Уведіть висоту піраміди:");
            Console.Write($"Об'єм такої піраміди дорівнює: {aWidth*aWidth*height/3F}\nНатисніть Enter щоб продовжити...");
            Console.ReadLine();
            break;
        case "5":
            Console.WriteLine("\nВи вибрали об'єм сфери");
            double r = getNumericFromConsole("Уведіть радіус сфери:");
            double pi = 3.14159265359;
            Console.Write($"Об'єм такої сфери дорівнює: {(4F / 3F) * pi * Math.Pow(r, 3)}\nНатисніть Enter щоб продовжити...");
            Console.ReadLine();
            break;
        default:
            break;
    }
}

double getNumericFromConsole(string message)
{
    Console.Write(message);
    double parsedInt = 0;
    while(true)
    {
        string response = Console.ReadLine();
        try
        {
            parsedInt = double.Parse(response);
            break;
        }
        catch (Exception)
        {
            Console.Write($"Невірно уведені дані, спробуйте ще раз.\n{message}");
        }
    }
    return parsedInt;
}

double calculateAreaOfATriangleByHeron(double a, double b, double c)
{
    double p = (a + b + c) / 2F;
    double tempCalc = p * (p - a) * (p - b) * (p - c);
    double resp = Math.Pow(tempCalc, (1F/2F));
    return resp;
}