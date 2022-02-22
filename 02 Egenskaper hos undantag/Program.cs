try
{
    string testString = "werfafdgh";
    CauseFormatException(testString);
    Console.WriteLine("Allt gick bra");
}

catch (FormatException ex)
{
    Console.Error.WriteLine("Exception: {0}\n{1}",
        ex.Message, ex.StackTrace);
}
catch (Exception)
{
    Console.Error.WriteLine("Något annat fel uppstod");
}

Console.Write("Tryck ENTER för att fortsätta");
Console.ReadLine();



static void CauseFormatException(string s)
{
    //string s = "Ett ogiltigt tal";
    int.Parse(s);
}