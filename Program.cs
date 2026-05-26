// -- iNaturalist Adventure Logbook  -- //

/* -- A first iteration of a diary or logbook application to record my adventures whilst doing
 * my new favourite hobby - conducting citizen science using the iNaturalist app on my phone, which 
 * allows users to take photos of plants, fungi and animals (mainly bugs) and get them identified and
 * in some instances even have the records taken used by entomologists in scientific research to do
 * with arthropod identification and distribution -- */

/* This first version will be text-only, however I hope to be able to quickly start work on a GUI version
 * as well so that it can look a little more interesting and include some of the photos as well (maybe even
 * some videos too) */

// Introduction

static void introduction()
{
    Console.WriteLine("Introduction - Under Construction");
    Console.WriteLine();
    Console.WriteLine("1. Back To Main Menu");
    Console.WriteLine("2. Exit Application");
    Console.WriteLine();
    Console.WriteLine("Enter Choice: ");
    int menuChoice = Convert.ToInt32(Console.ReadLine());

    if (menuChoice == 1)
    {
        Console.Clear();
        main();
    }
    else if (menuChoice == 2)
    {
        Environment.Exit(0);
    }
}

// New Logbook Entry

static void new_entry()
{
    Console.WriteLine("New Logbook Entry - Under Construction");
    Console.WriteLine();
    Console.WriteLine("1. Back To Main Menu");
    Console.WriteLine("2. Exit Application");
    Console.WriteLine();
    Console.WriteLine("Enter Choice: ");
    int menuChoice = Convert.ToInt32(Console.ReadLine());

    if (menuChoice == 1)
    {
        Console.Clear();
        main();
    }
    else if (menuChoice == 2)
    {
        Environment.Exit(0);
    }
}

// Saved Logbook Entries

static void saved_entries()
{
    Console.WriteLine("Saved Logbook Entries - Under Construction");
    Console.WriteLine();
    Console.WriteLine("1. Back To Main Menu");
    Console.WriteLine("2. Exit Application");
    Console.WriteLine();
    Console.WriteLine("Enter Choice: ");
    int menuChoice = Convert.ToInt32(Console.ReadLine());

    if (menuChoice == 1)
    {
        Console.Clear();
        main();
    }
    else if (menuChoice == 2)
    {
        Environment.Exit(0);
    }
}

// Main Menu & Program Start
static void main()
{
    Console.WriteLine("iNaturalist Adventure Logbook");
    Console.WriteLine();
    Console.WriteLine("Main Menu");
    Console.WriteLine("1. Introduction");
    Console.WriteLine("2. New Logbook Entry");
    Console.WriteLine("3. Saved Logbook Entries");
    Console.WriteLine("4. Exit Program");
    Console.WriteLine();
    Console.WriteLine("Enter Choice: ");
    int menuChoice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    while (menuChoice != 4)
    {
        if (menuChoice == 1)
        {
            Console.Clear();
            introduction();
        } 
        else if (menuChoice == 2) 
        {
            Console.Clear();
            new_entry();
        }
        else if (menuChoice == 3)
        {
            Console.Clear();
            saved_entries();
        }
        else
        {
            Console.WriteLine("Invalid Selection. Please Try Again: ");
            menuChoice = Convert.ToInt32(Console.ReadLine());
        }
    }
}

main();
