using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

class Illuminati
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string message = Console.ReadLine();
        List<char> chars = new List<char>();
        long sum = 0;
        foreach (char letter in message)
        {
            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                chars.Add(letter);
                switch (letter)
                {
                    case 'A': sum += 65; break;
                    case 'E': sum += 69; break;
                    case 'I': sum += 73; break;
                    case 'O': sum += 79; break;
                    case 'U': sum += 85; break;
                }
            }
            else if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                chars.Add(letter);
                switch (letter)
                {
                    case 'a': sum += 65; break;
                    case 'e': sum += 69; break;
                    case 'i': sum += 73; break;
                    case 'o': sum += 79; break;
                    case 'u': sum += 85; break;
                }
            }
        }
        Console.WriteLine(chars.Count);
        Console.WriteLine(sum);
    }
}
