namespace ConnectFour.Utils;

internal class ClosedInterval
{
    private int _min;
    private int _max;

    public ClosedInterval(int min, int max)
    {
        _min = min;
        _max = max;
    }

    internal bool IsValid(int value)
    {
        return _min <= value && value <= _max;
    }
}