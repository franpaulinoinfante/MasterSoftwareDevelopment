namespace TicTacToe.Utils.Coordinates;

public class ConcreteCoordinate : ICoordinate
{
    public static string ROW = "Row: ";
    public static string COLUNM = "Colunm: ";

    private readonly int _row;
    private readonly int _column;

    public ConcreteCoordinate()
    { }

    public ConcreteCoordinate(int row, int column)
    {
        _row = row;
        _column = column;
    }

    public int Row => _row;

    public int Column => _column;

    public bool IsNull()
    {
        return false;
    }

    public Direction GetDirection(ICoordinate coordinate)
    {
        if (this.Equals(coordinate) || IsNull())
        {
            return Direction.NULL;
        }
        if (IsInHorizonal(coordinate))
        {
            return Direction.HORIZONTAL;
        }
        if (IsInVertical(coordinate))
        {
            return Direction.VERTICAL;
        }
        if (IsInMainDiagonal())
        {
            return Direction.MAIN_DIAGONAL;
        }
        return Direction.NULL;
    }

    public bool IsInHorizonal(ICoordinate coordinate)
    {
        return _row == ((ConcreteCoordinate)coordinate)._row;
    }

    public bool IsInVertical(ICoordinate coordinate)
    {
        return _column == ((ConcreteCoordinate)coordinate)._column;
    }

    public bool IsInMainDiagonal()
    {
        return _row - _column == 0;
    }
}
