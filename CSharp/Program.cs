using System;
using CSharp.Problems;

class Program
{
    static void Main()
    {
        // Lucian's Luscious Lasagna
        var lasagna = new Lasagna();

        Console.WriteLine("Lucian's Luscious Lasagna");
        Console.WriteLine("Expected Minutes in Oven: " + lasagna.ExpectedMinutesInOven());
        Console.WriteLine("Remaining Minutes in Oven (actual 30): " + lasagna.RemainingMinutesInOven(30));
        Console.WriteLine("Preparation Time (3 layers): " + lasagna.PreparationTimeInMinutes(3));
        Console.WriteLine("Elapsed Time (3 layers, 20 minutes in oven): " + lasagna.ElapsedTimeInMinutes(3, 20));
    }
}