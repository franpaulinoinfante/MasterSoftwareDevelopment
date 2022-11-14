namespace Connect4.Models.Types;

internal class Line
{
    internal static int Length = 4;

    private readonly Coordinate _origin;
    private Coordinate[] _coordinates;
    private Direction _oppositeDirection;

    public Line(Coordinate origin)
    {
        _origin = origin;
    }

    internal Coordinate[] Coordinates { get => _coordinates; }

    public Direction Direction
    {
        set
        {
            Direction direction = value;
            _coordinates = new Coordinate[Length];
            _coordinates[0] = _origin;
            for (int i = 1; i < Line.Length; i++)
            {
                _coordinates[i] = _coordinates[i - 1].Shifted(direction.Coordinate);
            }
            _oppositeDirection = direction.GetOpposite();
        }
    }

    internal void Shift()
    {
        for (int i = 0; i < _coordinates.Length; i++)
        {
            _coordinates[i] = _coordinates[i].Shifted(_oppositeDirection.Coordinate);
        }
    }
}