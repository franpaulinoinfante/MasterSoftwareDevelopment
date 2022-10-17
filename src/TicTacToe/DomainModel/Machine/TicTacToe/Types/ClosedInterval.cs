namespace TicTacToe.Types;

internal class ClosedInterval
{
    private readonly int _min;
    private readonly int _max;

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
