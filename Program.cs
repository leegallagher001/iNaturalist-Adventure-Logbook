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
    Console.WriteLine("iNaturalist Adventure Logbook - Introduction");
    Console.WriteLine();
    Console.WriteLine("Hello, and welcome to the iNaturalist Adventure Logbook!");
    Console.WriteLine();
    Console.WriteLine("My name is Lee. Having had a renewed interest and obsession with science recently, I wanted to find a way to contribute to citizen science, and so I ended up finding the iNaturalist mobile app, which allows users to take photos of animals, primarily bugs, and allows for the identification of them - either manually or automatically by the app itself. Other data, such as the time the photo/observation was taken and the location, are also recorded.");
    Console.WriteLine();
    Console.WriteLine("The app effectively acts as a repository of observations taken, which can then even be used by entomologists and other researchers in their research papers, since high-quality observations can give insights into different species and their distributions, and in some cases even lead to the discovery of species entirely new to science - there have even been cases where species thought to be extinct have been discovered alive thanks to iNaturalist!");
    Console.WriteLine();
    Console.WriteLine("What I ultimately hope to do with this app in the long term is to build a place where iNaturalist enthusiasts can record their days out and adventures using the app. Personally, I hope to spend a lot more time using the app, and it would be nice to have a logbook to complement the iNaturalist records taken during a walk or a day out or a longer adventure - a place where the adventure as a whole can be discussed, putting observations into a larger context or 'bigger picture' that could include a text summary of the day out as well as all of the photos and videos taken, that might allow a greater understanding of the things we see and observe and record.");
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
