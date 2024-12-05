while (true)
{
    Console.Clear();
    Console.WriteLine("Hej användare! Du spelar som tonåriga superhjältar som går på skolan Superhero Academy och ska välja superkraft. Vilken vill du välja? (A/B/C)");
    Console.WriteLine("A. Tjock (+defense)");
    Console.WriteLine("B. Katkus (+motstondaren tar skada när de attackerar)");
    Console.WriteLine("C. Grön (Mutual Destruction)");
    string? HeroAnswer = Console.ReadLine();
    if (HeroAnswer == "A")
    {   
        Tjock.Vald = true;
        Console.WriteLine("Du valde tjock! Nu välj ett namn: ");
        Tjock.Name = Console.ReadLine();
        Console.WriteLine($"du valde" +(Tjock.Name) + ". Vill du behålla? (J/N)");
        string Behålla = Console.ReadLine();
        if (Behålla == "J")
        {
            Console.WriteLine("Du ska nu slå mot en träningsmåltavla so msjuter tillbaka");
            Console.WriteLine("");
        }
        else
        {
            HeroAnswer = "D";
        }
    }
    else if (HeroAnswer == "B")
    {
        Kaktus.Vald = true;
        Kaktus.Vald = true;
        Console.WriteLine("Du valde kaktus! Nu välj ett namn: ");
        Kaktus.Name = Console.ReadLine();
        Console.WriteLine($"du valde" +(Kaktus.Name) + ". Vill du behålla? (J/N)");
        string Behålla = Console.ReadLine();
        if (Behålla == "J")
        {
            Console.WriteLine("Du ska nu slå mot en träningsmåltavla so msjuter tillbaka");
            Console.WriteLine("");
        }
        else
        {
            HeroAnswer = "D";
        }
    }
    else if (HeroAnswer == "C")
    {
        Grön.Vald = true;
        Grön.Vald = true;
        Console.WriteLine("Du valde grön! Nu välj ett namn: ");
        Grön.Name = Console.ReadLine();
        Console.WriteLine($"du valde" +(Grön.Name) + ". Vill du behålla? (J/N)");
        string Behålla = Console.ReadLine();
        if (Behålla == "J")
        {
            Console.WriteLine("Du ska nu slå mot en träningsmåltavla so msjuter tillbaka");
            Console.WriteLine("Vill du använda din kraft? (J/N) ");
            
        }
        else
        {
            HeroAnswer = "D";
        }
    }
    else if (HeroAnswer == "D"){
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Var snäll och skriv A, B eller C för att välja");
    }
}