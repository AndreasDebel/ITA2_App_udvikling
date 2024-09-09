namespace Modul2;

public class Opgave2_4
{
    public static void Run()
    {
        Console.WriteLine("Opgave 2.4");
        var inp = Console.ReadLine();
        
    }

    static bool IsPalindrome(string s)
    {
        int min = 0, max = s.Length - 1;
        while (min < max)
        {
            if (s[min] != s[max])
                return false;
            
        }

        return true;
    }
}