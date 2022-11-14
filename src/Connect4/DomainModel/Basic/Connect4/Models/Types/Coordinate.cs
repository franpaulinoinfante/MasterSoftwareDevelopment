namespace Connect4.Models.Types;

internal class Coordinate
{
    internal static Coordinate Origin = new Coordinate(0, 0);
    internal static int NumberRows = 6;
    internal static ClosedInterval Rows = new ClosedInterval(min: 0, Coordinate.NumberRows - 1);
    internal static int NumberColunms = 7;
    internal static ClosedInterval Colunms = new ClosedInterval(min: 0, Coordinate.NumberColunms - 1);

    private int _row;
    private int _colunm;

    public Coordinate(int row, int colunm)
    {
        _row = row;
        _colunm = colunm;
    }

    public int Row { get => _row; set => _row = value; }
    public int Colunm { get => _colunm; set => _colunm = value; }

    internal Coordinate Shifted(Coordinate coordinate)
    {
        return new Coordinate(Row + coordinate.Row, Colunm + coordinate.Colunm);
    }

    internal bool Equals(Coordinate coordinate)
    {
        return _row == coordinate.Row && _colunm == coordinate.Colunm;
    }

    internal bool IsValid()
    {
        return Coordinate.IsRowValid(Row) && Coordinate.IsColunmValid(Colunm);
    }

    private static bool IsRowValid(int row)
    {
        return Coordinate.Rows.IsIncluided(row);
    }

    internal static bool IsColunmValid(int colunm)
    {
        return Coordinate.Colunms.IsIncluided(colunm);
    }
}
