namespace ConnectFour.Utils;

public class Line
{
    public static int Length = 4;

    private readonly Coordinate[] _coordinates;
    private readonly Coordinate _coordinate;
    private Direction _oppositeDirection;

    public Line(Coordinate coordinate)
    {
        _coordinates = new Coordinate[Line.Length];
        _coordinate = coordinate;
        _oppositeDirection = Direction.Null;
    }

    public Coordinate[] Coordinates => _coordinates;

    public Direction Direction
    {
        set
        {
            _coordinates[0] = _coordinate;
            for (int i = 1; i < Line.Length; i++)
            {
                _coordinates[i] = _coordinates[i - 1].Shifted(value.Coordinate);
            }

            _oppositeDirection = value.OppositeDirection;
        }
    }
    
    public void Shift()
    {
        for (int i = 0; i < Line.Length; i++)
        {
            _coordinates[i] = _coordinates[i].Shifted(_oppositeDirection.Coordinate);
        }
    }
}
