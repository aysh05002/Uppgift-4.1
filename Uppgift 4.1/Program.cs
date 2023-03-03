using System;

class program
{
    static void Main(string[] args)
    {
        for (int i = 10; i <= 30; i++)
        {
            Console.Write(i + " \t ");
        }
        Console.WriteLine();
        for (int i = 200; i >= 180; i--)
        {
            Console.Write(i + " \t ");
        }
        Console.WriteLine();
        for (int i = 1000; i <= 1400; i += 50)
        {
            Console.Write(i + " \t ");
        }
    }
}
