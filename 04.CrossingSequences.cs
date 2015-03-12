using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

class CrossingSequences
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<long> tribunaci = new List<long>();
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        tribunaci.Add(a);
        tribunaci.Add(b);
        tribunaci.Add(c);
        tribunaci.Sort();
        for (int i=3; i<1000000;i++)
        {
            long nextNum = a+b+c;
            a = b;
            b = c;
            c = nextNum;
            if (nextNum <= 1000000)
            {

                tribunaci.Add(nextNum);
            }
            else
            {
                break;
            }
        }
        long initialNumber = long.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        List<long> spiral = new List<long>();
        bool odd = true;
        long line = 0;
        for (long i = initialNumber; i <= 1000000;)
        {
            spiral.Add(i);
            if (odd)
            {
                line += 1;
            }
            i += line * step;
            odd = !odd;
        }
        bool coincidence = false;
        foreach (int num in spiral)
        {
            coincidence = tribunaci.Contains(num);
            if (coincidence)
            {
                Console.WriteLine(num);
                break;
            }
        }
        if (!coincidence)
        {
            Console.WriteLine("No");
        }

    }
}
