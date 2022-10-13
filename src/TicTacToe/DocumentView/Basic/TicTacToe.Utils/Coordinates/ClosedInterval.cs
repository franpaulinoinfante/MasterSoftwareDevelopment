namespace TicTacToe.Utils.Coordinates;

public class ClosedInterval
{
    private int _min;
    private int _max;

    public ClosedInterval(int min, int max)
    {
        _min = min;
        _max = max;
    }

    public bool IsIncluide(int value)
    {
        return _min <= value && value <= _max;
    }
}