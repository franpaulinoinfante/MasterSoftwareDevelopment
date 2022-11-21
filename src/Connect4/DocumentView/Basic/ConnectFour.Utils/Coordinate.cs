namespace ConnectFour.Utils;

public class Coordinate
{
    public static int Rows = 6;
    public static int Colunms = 7;

    private int _row;
    private int _column;

    public Coordinate()
    {
        //Empty Coordinate
    }

    public Coordinate(int row, int column)
    {
        _row = row;
        _column = column;
    }

    public int Row { get => _row; set => _row = value; }
    public int Column { get => _column; set => _column = value; }

    public Coordinate Shifted(Coordinate coordinate)
    {
        return new Coordinate(_row + coordinate.Row, Column + coordinate.Column);
    }

    public bool IsValid()
    {
        return new ClosedInterval(Coordinate.Rows, Coordinate.Colunms).IsIncluided(_row) && new ClosedInterval(Coordinate.Rows, Coordinate.Colunms).IsIncluided(_column);
    }

    public bool IsValid(int value)
    {
        return new ClosedInterval(min: 0, Coordinate.Colunms - 1).IsIncluided(value);
    }
}
