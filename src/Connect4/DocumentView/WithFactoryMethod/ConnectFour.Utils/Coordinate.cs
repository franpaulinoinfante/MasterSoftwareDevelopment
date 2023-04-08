namespace ConnectFour.Utils;

public class Coordinate
{
    public const int MaxRows = 6;
    public const int MaxColumns = 7;

    private int _row;
    private int _column;

    public Coordinate(int row, int column)
    {
        _row = row;
        _column = column;
    }

    public int Row { get => _row; set => _row = value; }
    public int Column { get => _column; set => _column = value; }

    public bool IsValid(int value)
    {
        return new ClosedInterval(min: 0, _column).IsIncluide(value);
    }

    public Coordinate Shifted(Coordinate coordinate)
    {
        return new Coordinate(_row + coordinate.Row, _column + coordinate.Column);
    }

    public bool Equals(Coordinate other)
    {
        return _row == other.Row && _column == other.Column;
    }

    public bool IsIncluided()
    {
        return
            new ClosedInterval(min: 0, MaxRows - 1).IsIncluide(_row) &&
            new ClosedInterval(min: 0, MaxColumns - 1).IsIncluide(_column);
    }
}
