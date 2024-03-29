﻿internal class Interval
{
    private readonly int _min;
    private readonly int _max;

    public Interval(int min, int max)
    {
        _min = min;
        _max = max;
    }

    internal bool Incuide(int value)
    {
        return _min <= value && value <= _max;
    }
}