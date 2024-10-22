namespace BlazorApp1.Model.DiceStuff;

public class TestDice
{
    public static void Run()
    {
        MafiaDice d = new MafiaDice();
        int[] rul = new int[7];

        for (int i = 0; i < 100000; i++)
        {
            d.Roll();
            int eyes = d.GetEyes();
            rul[eyes]++;
            //Console.WriteLine(eyes);
        }


        for (int i = 1; i < 7; i++)
        {
            Console.WriteLine($"Tallet {i} er blevet slået {rul[i]} gange.");
        }
    }
}