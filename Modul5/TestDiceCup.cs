namespace Modul5;

public class TestDiceCup
{
    public static void Run()
    {
        DiceCup dc = new DiceCup(5);

        List<CupLiftEvent> events = dc.GetHistory();

        for (int i = 0; i < 3; i++)
        {
            Console.ReadLine();
            dc.ShakeCup();
            dc.LiftCup();

            Console.WriteLine(string.Join(", ", dc.eyesList));

            //events = dc.GetHistory();
            //for (int j = 0; j < events.Count; j++)
            //{
            //    string eyesString = string.Join(", ", events[j]._eventEyes);
            //    Console.WriteLine($"Cup Lift {j} -- Date: {events[j]._eventTime}. Eyes: {eyesString}");
            //}
        }

        Console.ReadLine();

        events = dc.GetHistory();
        for (int i = 0; i < events.Count; i++)
        {
            string eyesString = string.Join(", ", events[i]._eventEyes);
            Console.WriteLine($"Cup Lift {i} -- Date: {events[i]._eventTime}. Eyes: {eyesString}");
        }


    }
}