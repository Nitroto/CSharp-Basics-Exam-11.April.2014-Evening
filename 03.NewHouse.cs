using System;
using System.Globalization;
using System.Threading;

class NewHouse
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = Int32.Parse(Console.ReadLine());
        int half = (n / 2) + 1;
        int roofSpacing = n / 2;
        int roof = 1;
        int floor = n - 2;
        for (int i = 0; i < half; i++)
        {
            Console.Write(new string('-', roofSpacing));
            Console.Write(new string('*', roof));
            Console.Write(new string('-', roofSpacing));
            roof += 2;
            roofSpacing--;
            Console.WriteLine();
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("|");
            Console.Write(new string('*', floor));
            Console.Write("|");
            Console.WriteLine();
        }
    }
}
