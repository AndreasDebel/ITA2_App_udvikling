namespace Modul7;

public class TestDice
{
    public static void Run()
    {
        MafiaDice d = new MafiaDice(20);

        for (int i = 0; i < 10; i++)
        {
            d.Roll();
            int eyes = d.GetEyes();
            Console.WriteLine(eyes);
        }
    }
}