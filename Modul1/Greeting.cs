namespace Modul1;

public class Greeting
{
    public static void Run()
    {
        Console.Write("Indtast din fars navn: ");
        string navn = Console.ReadLine();
        DateTime nu = DateTime.Now;
        Console.WriteLine(nu);
        if (nu.Hour < 10)
            Console.WriteLine($"God morgen {navn} - håber du får en god dag.");
        else
            Console.WriteLine($"God dag {navn} - håber du har en god morgen...");
    }
}