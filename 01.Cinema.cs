using System;
using System.Globalization;
using System.Threading;

class Cinema
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string typeOfProjection = Console.ReadLine();
        byte rows = Byte.Parse(Console.ReadLine());
        byte columns = Byte.Parse(Console.ReadLine());
        double price=0.00;
        switch (typeOfProjection)
        {
            case "Premiere": price = 12.00; break;
            case "Normal": price = 7.50; break;
            case "Discount": price = 5.00; break;
        }
        double incomes = rows * columns * price;
        Console.WriteLine("{0:f2} leva", incomes);
    }
}
