namespace TicTacToe.Models.Types;

public class Coordinate
{
    public static readonly int DIMENSION = 3;
    public const string ROW = "Row: ";
    public const string COLUMN = "Column: ";

    private int _row;
    private int _column;

    public Coordinate()
    {
    }

    public Coordinate(int row, int column)
    {
        _row = row;
        _column = column;
    }

    public int Row { get => _row; set => _row = value; }

    public int Column { get => _column; set => _column = value; }

    public Coordinate Random()
    {
        Random random = new Random();

        _row = random.Next(minValue: 0, DIMENSION);
        _column = random.Next(minValue: 0, DIMENSION);
        Task.Delay(500).Wait();
        return this;
    }

    public bool IsValid()
    {
        return new ClosedInterval(min: 0, Coordinate.DIMENSION - 1).IsIncluide(_row) && 
            new ClosedInterval(min: 0, Coordinate.DIMENSION - 1).IsIncluide(_column);
    }

    public Direction GetDirection(Coordinate coordinate)
    {
        if (InHorizontal(coordinate))
        {
            return Direction.HORIZONTAL;
        }
        if (InVertical(coordinate))
        {
            return Direction.VERTICAL;
        }
        if (InMainDiagonal())
        {
            return Direction.MAIN_DIAGONAL;
        }
        if (InInverseDiagonal())
        {
            return Direction.INVERSE_DIAGONAL;
        }
        return Direction.NULL;
    }

    private bool InHorizontal(Coordinate coordinate)
    {
        return _row == coordinate.Row;
    }

    private bool InVertical(Coordinate coordinate)
    {
        return _column == coordinate.Column;
    }

    private bool InMainDiagonal()
    {
        return _row - _column == 0;
    }

    private bool InInverseDiagonal()
    {
        return _row + _column == Coordinate.DIMENSION - 1;
    }

    public ErrorType IsIncluide(Coordinate coordinate)
    {
        throw new NotImplementedException();
    }
}
