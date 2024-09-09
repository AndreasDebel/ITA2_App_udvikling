namespace Modul4;

public class TestDice
{
    public static void Run()
    {
        Dice d = new Dice(20);

        for (int i = 0; i < 10; i++)
        {
            d.Roll();
            int eyes = d.GetEyes();
            Console.WriteLine(eyes);
        }
    }
}