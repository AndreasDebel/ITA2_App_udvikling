namespace Modul5;

public class DiceCup
{
    private List<Dice> diceList;
    public List<int> eyesList { get; private set; }

    public DiceCup(int numberOfDice = 2)
    {
        diceList = new List<Dice>();
        eyesList = new List<int>();

        for (int i = 0; i < numberOfDice; i++)
        {
            diceList.Add(new Dice());
            eyesList.Add(0);
        }
    } 

    //public int a_eyes { get; private set; }
    //public int b_eyes { get; private set; }

    //public DiceCup()
    //{
    //    Dice a = new Dice();
    //    Dice b = new Dice();


    //}
    public void ShakeCup()
    {
        foreach (Dice dice in diceList)
        {
            dice.Roll();
        }
    }

    public void LiftCup()
    {
        for (int i = 0; i < diceList.Count; i++)
        {
            eyesList[i] = diceList[i].GetEyes();
        }
    }
}

