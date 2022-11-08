namespace Connect4.Models.Types;

internal class Direction
{
    internal static Direction North = new Direction(1, 0);
    internal static Direction NorthEast = new Direction(1, 1);
    internal static Direction East = new Direction(0, 1);
    internal static Direction SouthEast = new Direction(-1, 1);
    internal static Direction South = new Direction(-1, 0);
    internal static Direction SouthWest = new Direction(-1, -1);
    internal static Direction West = new Direction(0, -1);
    internal static Direction NorthWest = new Direction(1, -1);

    private readonly Coordinate _coordinate;

    public Direction(int row, int colunm)
    {
        _coordinate = new Coordinate(row, colunm);
    }

    public Coordinate Coordinate => _coordinate;

    internal Direction GetOpposite()
    {
        foreach (Direction direction in Direction.Directions())
        {
            if (direction._coordinate.Shifted(_coordinate).Equals(Coordinate.Origin))
            {
                return direction;
            }
        }
        return null;
    }

    internal static List<Direction> Directions()
    {
        return new List<Direction>()
        {
            Direction.North, Direction.NorthEast, Direction.East, Direction.SouthEast,
            Direction.South, Direction.SouthWest, Direction.West, Direction.NorthWest
        };
    }
}
