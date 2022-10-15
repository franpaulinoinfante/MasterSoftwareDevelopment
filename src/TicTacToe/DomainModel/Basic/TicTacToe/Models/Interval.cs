internal class Interval
{
    private int _min;
    private int _max;

    public Interval(int min, int max)
    {
        _min = min;
        _max = max;
    }

    internal bool Incuide(int row)
    {
        return _min <= row && row <= _max;
    }
}