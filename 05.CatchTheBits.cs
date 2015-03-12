using System;
using System.Globalization;
using System.Threading;
class CatchTheBits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = Int32.Parse(Console.ReadLine());
        int step = Int32.Parse(Console.ReadLine());
        int counter = 0;
        int position = 7;
        int newNum = 0;
        for (int i = 0; i < n; i++)
        {
            int num = Int32.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                if (counter % step == 1 || (step == 1 && counter > 0))
                {
                    int extractedBit = (num >> bit) & 1;
                    newNum = extractedBit << position | newNum;
                    position--;
                    if (position < 0)
                    {
                        Console.WriteLine(newNum);
                        newNum = 0;
                        position = 7;
                    }
                }
                counter++;
            }
        }
        if (position < 7)
        {
            Console.WriteLine(newNum);
        }
    }
}