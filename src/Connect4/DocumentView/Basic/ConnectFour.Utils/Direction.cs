namespace ConnectFour.Utils;

public class Direction
{
    public static Direction North = new Direction(1, 0);
    public static Direction NorthEast = new Direction(1, 1);
    public static Direction East = new Direction(0, 1);
    public static Direction SouthEast = new Direction(-1, 1);
    public static Direction South = new Direction(-1, 0);
    public static Direction SouthWest = new Direction(-1, -1);
    public static Direction West = new Direction(0, -1);
    public static Direction NorthWest = new Direction(1, -1);

    private readonly Coordinate _coordinate;

    public Direction(int row, int colunm)
    {
        _coordinate = new Coordinate(row, colunm);
    }

    public Coordinate Coordinate => _coordinate;

    public Direction? OppositeDirection
    {
        get
        {
            foreach (Direction direction in Directions)
            {
                if (direction._coordinate.Shifted(_coordinate).Equals(new Coordinate()))
                {
                    return direction;
                }
            }

            return null;
        }
    }

    public static List<Direction> Directions
    {
        get
        {
            return new List<Direction>()
            {
                Direction.North, Direction.NorthEast, Direction.East, Direction.SouthEast,
                Direction.South, Direction.SouthWest, Direction.West, Direction.NorthWest
            };
        }
    }
}
