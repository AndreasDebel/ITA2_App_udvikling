namespace Modul5;

public class DiceCup
{
    private List<Dice> diceList;
    public List<int> eyesList { get; private set; }
    public List<CupLiftEvent> cupHistory = new();

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

        List<int> eyesCopy = new List<int>(eyesList);

        CupLiftEvent CLevent = new CupLiftEvent(eyesCopy, DateTime.Now);
        cupHistory.Add(CLevent);
    }

    public List<CupLiftEvent> GetHistory()
    {          
        return cupHistory;        
    }


}

