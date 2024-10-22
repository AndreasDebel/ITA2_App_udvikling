namespace BlazorApp1.Model.DiceStuff;

public class Dice
{
    protected int _eyes;

    private int _size;
    private Random _random; 

    public Dice()
    {
        _random = new Random();
        _size = 6;
    }

    public Dice(int size)
    {
        _random = new Random();
        _size = size;
    }

    public void Roll()
    {
        _eyes = _random.Next(_size)+1;
    }

    public virtual int GetEyes()
    {
        return _eyes;
    }
}