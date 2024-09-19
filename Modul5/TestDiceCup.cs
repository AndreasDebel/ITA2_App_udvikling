namespace Modul5;

public class TestDiceCup
{
    public static void Run()
    {
        DiceCup dc = new DiceCup();

        dc.ShakeCup();
        dc.LiftCup();
        int[] eyes_array = new int[] { dc.a_eyes, dc.b_eyes };
        Console.WriteLine(string.Join(", ", eyes_array));
    }
}