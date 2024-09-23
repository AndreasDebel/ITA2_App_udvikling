namespace Modul5;

public class TestDiceCup
{
    public static void Run()
    {
        DiceCup dc = new DiceCup();

        dc.ShakeCup();
        dc.LiftCup();

        Console.WriteLine(string.Join(", ", dc.eyesList));
    }
}