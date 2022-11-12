using ConnectFourConsoleApp.Utils;

namespace ConnectFourConsoleApp.Types;

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

    internal Coordinate[] Coordinates => _coordinates;

    public Direction Direction
    {
        set
        {
            _coordinates = new Coordinate[Length];
            _coordinates[0] = _origin;
            for (int i = 1; i < Length; i++)
            {
                _coordinates[i] = _coordinates[i - 1].Shifted(value.Coordinate);
            }
            _oppositeDirection = value.OppositeDirection;
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