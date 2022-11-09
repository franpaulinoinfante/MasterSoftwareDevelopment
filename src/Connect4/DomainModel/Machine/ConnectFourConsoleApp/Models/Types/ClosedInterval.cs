namespace ConnectFourConsoleApp.Models.Types;

internal class ClosedInterval
{
    private int _min;
    private int _max;

    public ClosedInterval(int min, int max)
    {
        _min = min;
        _max = max;
    }

    internal bool IsValid(int colunm)
    {
        return _min <= colunm && colunm <= _max;
    }
}