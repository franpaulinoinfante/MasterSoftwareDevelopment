namespace ConnectFour.Utils;

internal class Coordinate
{
    private int _row;
    private int _column;

    public Coordinate(int row, int column)
    {
        _row = row;
        _column = column;
    }

    public bool IsValid(int value)
    {
        return new ClosedInterval(min: 0, _column - 1).IsIncuided(value);
    }
}
