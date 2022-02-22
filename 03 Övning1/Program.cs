int number1 = 0;
int number2 = 0;
int division = 0;


try
{
    Console.Write("Ange tal att dela: ");
    number1 = int.Parse(Console.ReadLine());
    Console.Write("Ange tal att dela med: ");
    number2 = int.Parse(Console.ReadLine());

    division = number1 / number2;
    Console.WriteLine("{0} / {1} = {2}", number1, number2, division);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Kan inte dividera med noll");
}
catch (FormatException)
{
    Console.WriteLine("Ogiltigt format");
}
catch (Exception)
{
    Console.WriteLine("Något annat gick fel. Kontakta supporten.");
}

Console.Write("Tryck på valfri tangent för att fortsätta");
Console.ReadKey();