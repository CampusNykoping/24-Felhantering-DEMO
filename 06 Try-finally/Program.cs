

TestTryFinally();


Console.Write("\n\nTryck på valfri tangent för att fortsätta");
Console.ReadKey();


void TestTryFinally()
{
    Console.WriteLine("Detta körs före try-catch-finally");
    try
    {
        Console.Write("Ange ett heltal: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Parsing gick bra, du angav {0}", i);
        return;
    }
    catch (Exception)
    {
        Console.WriteLine("Parse gick fel!");
        //return;
    }

    finally
    {
        Console.WriteLine("Inne i finally  - detta körs alltid");
    }

    Console.WriteLine("Nu är vi efter try-catch-finally");
}
