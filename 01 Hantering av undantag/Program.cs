
while (true)
{
    Console.Write("Ange ett heltal: ");
    string s = Console.ReadLine();

    // Det går inte att mata in null, så vi fuskar litet:
    if (s == "-1")
    {
        s = null;
    }


    try
    {        
        int i = int.Parse(s);
        int j = 1 / i;

        Console.WriteLine("Du angav ett heltal: {0}", i);
        //break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Ogiltigt heltal");
    }
    catch (OverflowException)
    {
        Console.WriteLine("För stort tal");
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("Du kan inte ange NULL");
    }
    catch (DivideByZeroException) 
    {
        Console.WriteLine("Det går inte att dividera med noll");
    }
    catch 
    {
        Console.WriteLine("Något annat gick fel, fan vet vad...");
    }
}