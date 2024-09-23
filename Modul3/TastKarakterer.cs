namespace Modul3;
using System.Collections.Generic;
using System.Linq;

public class TastKarakterer
{
    public static void Run()
    {
        List<int> grades = new();

        bool moreGrades = true;
        while (moreGrades == true)
        {
            Console.WriteLine("Indtast en karakter eller tast x.");
            string gradeString = Console.ReadLine().ToLower();
            if (gradeString == "x")
            {
                moreGrades = false;
            } else
            {
                grades.Add(Convert.ToInt32(gradeString));
            }

        }

        double avg = grades.Average();
        Console.WriteLine($"Gennemsnit = {avg}");


        Dictionary<int, int> counts = new();

        int[] validGrades = { -3, 0, 2, 4, 7, 10, 12 };

        foreach(int grade in grades)
        {
            if (counts.ContainsKey(grade))
            {
                counts[grade]++;
            }
            else if (validGrades.Contains(grade))
            {
                counts[grade] = 1;
            }
        }

        foreach (var entry in counts)
        {
            Console.WriteLine($"Number {entry.Key} appears {entry.Value} times.");
        }

    }

    private static int ReadInt(string question)
    {
        Console.Write(question);
        return Convert.ToInt32(Console.ReadLine());
    }

    private static int Count(int[] a, int key)
    {
        int c = 0;
        foreach (var tal in a)
            if (tal == key)
                c++;
        return c;
    }
}