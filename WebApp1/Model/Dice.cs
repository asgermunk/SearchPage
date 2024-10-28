namespace WebApp1.Model;

public class Dice
{
    public int _myEyes;
    public int _size;
    public Random _myRandom;

    public Dice(int size = 6)
    {
        _myRandom = new Random();
        _size = size;
    }

    public void Roll()
    {
        _myEyes = _myRandom.Next(_size) + 1;
    }

    public int GetEyes()
    {
        return _myEyes;
    }
}