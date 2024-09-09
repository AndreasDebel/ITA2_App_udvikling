namespace Modul3;

public class Opgave3_1
{
    public static void Run()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        double avg = Average(a);
        Console.WriteLine($"Gennemsnit = {avg}");
        Console.WriteLine($"Varians = {Varians(a)}");
        Console.WriteLine($"Deviation = {Deviation(a)}");
    }

    public static double Average(int[] a)
    {
        double sum = 0;
        foreach (int tal in a)
            sum += tal;
        return sum / a.Length;
    }
    
    static double Varians(int[] a)
    {
        double avg = Average(a);
        double varians = 0;
        foreach (int tal in a)
            varians += (tal-avg)*(tal-avg);
        return varians / a.Length;
    }

    static double Deviation(int[] a) => Math.Sqrt(Varians(a));

}