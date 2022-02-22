string firstName;
string ageText;
int age;
int result = 0;

Console.Write("Ange ditt förnamn: ");
firstName = Console.ReadLine();

Console.Write("Ange din ålder: ");
ageText = Console.ReadLine();

try
{
    age = int.Parse(ageText);
    Console.WriteLine($"Hej {firstName}! Du är {age * 12} månader gammal");
}
catch (FormatException)
{
    Console.WriteLine($"Den angivna åldern, {ageText}, är ogiltig");
}

catch (Exception)
{
    Console.WriteLine("Något annat gick fel");
}

Console.Write("Tryck på valfri tangent för att fortsätta");
Console.ReadKey();