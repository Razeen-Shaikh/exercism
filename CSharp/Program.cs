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

        // Annalyn's Infiltration
        var infiltration = new AnnalynsInfiltration();
        Console.WriteLine("\nAnnalyn's Infiltration");
        Console.WriteLine("Can Fast Attack (knight awake): " + infiltration.CanFastAttack(true));
        Console.WriteLine("Can Spy (knight awake, archer awake, prisoner awake): " + infiltration.CanSpy(true, true, true));
        Console.WriteLine("Can Signal Prisoner (archer awake, prisoner awake): " + infiltration.CanSignalPrisoner(true, true));
        Console.WriteLine("Can Free Prisoner (knight awake, archer awake, prisoner awake, pet dog present): " + infiltration.CanFreePrisoner(true, true, true, true));
        Console.WriteLine("Can Free Prisoner (knight awake, archer awake, prisoner awake, pet dog not present): " + infiltration.CanFreePrisoner(true, true, true, false));
        Console.WriteLine("Can Free Prisoner (knight not awake, archer awake, prisoner awake, pet dog present): " + infiltration.CanFreePrisoner(false, true, true, true));
        Console.WriteLine("Can Free Prisoner (knight not awake, archer awake, prisoner awake, pet dog not present): " + infiltration.CanFreePrisoner(false, true, true, false));
        Console.WriteLine("Can Free Prisoner (knight not awake, archer not awake, prisoner awake, pet dog present): " + infiltration.CanFreePrisoner(false, false, true, true));
        Console.WriteLine("Can Free Prisoner (knight not awake, archer not awake, prisoner awake, pet dog not present): " + infiltration.CanFreePrisoner(false, false, true, false));
        Console.WriteLine("Can Free Prisoner (knight not awake, archer not awake, prisoner not awake, pet dog present): " + infiltration.CanFreePrisoner(false, false, false, true));
        Console.WriteLine("Can Free Prisoner (knight not awake, archer not awake, prisoner not awake, pet dog not present): " + infiltration.CanFreePrisoner(false, false, false, false));
    }
}