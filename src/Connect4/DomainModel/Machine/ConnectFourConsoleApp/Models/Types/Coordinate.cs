namespace ConnectFourConsoleApp.Models.Types;

internal class Coordinate
{
    public static int MaxRows = 6;
    public static int MaxColunms = 7;

    private int _row;
    private int _colunm;

    public Coordinate()
    {
        _row = 0;
        _colunm = 0;
    }

    public Coordinate(int rows, int colunms)
    {
        _row = rows;
        _colunm = colunms;
    }

    public int Row { get => _row; set => _row = value; }
    public int Colunm { get => _colunm; set => _colunm= value; }

    internal Coordinate Shifted(Coordinate coordinate)
    {
        return new Coordinate(_row + coordinate.Row, _colunm + coordinate.Colunm);
    }

    internal bool IsValid()
    {
        return 
            new ClosedInterval(Coordinate.MaxRows, Coordinate.MaxColunms).IsValid(_row) && 
            new ClosedInterval(Coordinate.MaxRows, Coordinate.MaxColunms).IsValid(_colunm);
    }

    internal bool IsValid(int value)
    {
        return new ClosedInterval(min: 0, Coordinate.MaxColunms).IsValid(value);
    }

    internal bool Equals(Coordinate coordinate)
    {
        return _row == coordinate.Row && _colunm == coordinate.Colunm;
    }
}
