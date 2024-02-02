using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("he", "math");
        Console.WriteLine(a.GetSummary());
    }
}