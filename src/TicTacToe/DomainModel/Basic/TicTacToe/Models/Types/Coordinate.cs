internal class Coordinate
{
    internal static int DIMENSION = 3;
    private const string ROW = "ROW: ";
    private const string COLUNM = "COLUNM: ";

    private int _row;
    private int _colunm;

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

    internal Coordinate Read(MessageType messageType)
    {
        bool valid;
        do
        {
            new Message(messageType).WriteLine();
            _row = ConsoleIO.GetInstance().ReadInt(ROW) - 1;
            _colunm = ConsoleIO.GetInstance().ReadInt(COLUNM) - 1;
            valid = IsValid();
            if (!valid)
            {
                new Error(ErrorType.WRONG_COORDINATES).WriteLine();
            }
        } while (!valid);
        return this;
    }

    private bool IsValid()
    {
        return new Interval(min: 0, Coordinate.DIMENSION - 1).Incuide(_row) &&
            new Interval(min: 0, Coordinate.DIMENSION - 1).Incuide(_colunm);
    }

    internal bool Equals(Coordinate coordinate)
    {
        return _row == coordinate._row && _colunm == coordinate._colunm;
    }

    internal Direction GetDirection(Coordinate coordinate)
    {
        if (InHorizonal(coordinate))
        {
            return Direction.HORIZONTAL;
        }
        if (IntVertical(coordinate))
        {
            return Direction.VERTICAL;
        }
        if (InMainDiagonal() && coordinate.InMainDiagonal())
        {
            return Direction.MAIN_DIAGONAL;
        }
        if (InInverseDiagonal())
        {
            return Direction.INVERSE_DIAGONAL;
        }
        return Direction.NULL;
    }

    private bool InHorizonal(Coordinate coordinate)
    {
        return _row == coordinate._row;
    }

    private bool IntVertical(Coordinate coordinate)
    {
        return _colunm == coordinate._colunm;
    }

    private bool InMainDiagonal()
    {
        return _row - _colunm == 0;
    }

    private bool InInverseDiagonal()
    {
        return _row + _colunm == Coordinate.DIMENSION - 1;
    }
}