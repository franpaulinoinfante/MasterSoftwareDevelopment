using ConnectFourConsoleApp.Models.Types;

namespace ConnectFourConsoleApp.Types;

internal class Coordinate
{
    internal static int ROW = 6;
    internal static int COLUNM = 7;

    private readonly int _row;
    private readonly int _colunm;

    public Coordinate()
    {
    }

    public Coordinate(int row, int colunm)
    {
        _row = row;
        _colunm = colunm;
    }

    public int Row => _row;
    public int Colunm => _colunm;

    public bool IsValid(int value)
    {
        return new Interval(min: 0, COLUNM - 1).Incluide(value);
    }

    internal Direction GetDirection(Coordinate coordinate)
    {
        if (InHorizonal(coordinate))
        {
            return Direction.Horizontal;
        }
        if (InVertical(coordinate))
        {
            return Direction.Vertical;
        }
        if (InMainDiagonal() && coordinate.InMainDiagonal() && _colunm == coordinate._colunm + 1)
        {
            return Direction.MainDiagonal;
        }
        if (InInverseDiagonal() && coordinate.InInverseDiagonal() && _colunm == coordinate._colunm - 1)
        {
            return Direction.InverseDiagonal;
        }
        return Direction.Null;
    }

    private bool InHorizonal(Coordinate coordinate)
    {
        return _row == coordinate._row ;
    }

    private bool InVertical(Coordinate coordinate)
    {
        return _colunm == coordinate._colunm ;
    }

    private bool InMainDiagonal()
    {
        return
            _row - _colunm == -1 ||
            _row - _colunm == -2 ||
            _row - _colunm == -3 ||
            _row - _colunm == 0 ||
            _row - _colunm == 1 ||
            _row - _colunm == 2;
    }

    private bool InInverseDiagonal()
    {
        return
            _row + _colunm == ROW - 1 ||
            _row + _colunm == ROW - 2 ||
            _row + _colunm == ROW - 3 ||
            _row + _colunm == ROW ||
            _row + _colunm == COLUNM ||
            _row + _colunm == COLUNM + 1;
    }
}
