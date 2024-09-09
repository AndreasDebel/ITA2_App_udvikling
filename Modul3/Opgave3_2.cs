namespace Modul3;

public class Opgave3_2
{
    public static void Run()
    {
        int count = ReadInt("Hvor mg karaktere skal indtastes:");
        int[] grades = new int[count];
        for (int i = 0; i < grades.Length; i++)
        {
            grades[i] = ReadInt($"Indtast karakter nr. {i+1}: ");
        }

        double avg = Opgave3_1.Average(grades);
        Console.WriteLine($"Gennemsnit = {avg}");

        int[] validGrades = { -3, 0, 2, 4, 7, 10, 12 };

        foreach (int aGrade in validGrades)
        {
            int counter = Count(grades, aGrade);
            if (counter > 0)
            {
                Console.WriteLine($"Der er {counter} af {aGrade}");
            }
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