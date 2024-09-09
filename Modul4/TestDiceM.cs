namespace Modul4;

public class TestDiceM 
{
    public static void Run()
    {
        CheatDice d = new CheatDice();

        int[] rul = new int[7];

        for (int i = 0; i < 1000000; i++)
        {
            d.Roll();
            int eyes = d.GetEyes();
            rul[eyes]++;
        }

        for (int i = 1; i < 7; i++)
        {
            Console.WriteLine($"Tallet {i} er blevet slået {rul[i]} gange.");
        }
    }
}