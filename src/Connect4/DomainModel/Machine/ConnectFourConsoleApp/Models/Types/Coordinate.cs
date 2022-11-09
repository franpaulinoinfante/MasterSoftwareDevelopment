namespace ConnectFourConsoleApp.Models.Types;

internal class Coordinate
{
    public static int Rows = 6;
    public static int Colunms = 7;

    private readonly int _rows;
    private readonly int _colunms;

    public Coordinate(int rows, int colunms)
    {
        _rows = rows;
        _colunms = colunms;
    }

    public int Row { get => _row; set => _row = value; }
    public int Colunm { get => _colunms; set => _colunms= value; }

    internal Coordinate Shifted(Coordinate coordinate)
    {
        return new Coordinate(_row + coordinate.Row, _colunm + coordiante.Colunm)
    }

    internal bool IsValid(int value)
    {
        return new ClosedInterval(min: 0, Coordinate.Colunms).IsValid(value);
    }

    internal bool Equals(Coordinate coordinate)
    {
        return _row == coordinate.Row && _colunm == coordinate.Colunm;
    }
}
