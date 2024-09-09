namespace Modul4;

public class CheatDice
{
    private int _eyes;

    private int _size;
    private Random _random; 

    public CheatDice()
    {
        _random = new Random();
        _size = 6;
    }

    public CheatDice(int size)
    {
        _random = new Random();
        _size = size;
    }

    public void Roll()
    {
        _eyes = _random.Next(_size)+1;
        if (_eyes != 6)
            _eyes = _random.Next(_size)+1;
    }

    public int GetEyes()
    {
        return _eyes;
    }
}