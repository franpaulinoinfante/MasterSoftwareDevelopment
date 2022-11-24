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
    public static Direction Null = new Direction(0, 0);

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
                if (direction._coordinate.Shifted(_coordinate).Equals(new Coordinate(row: 0, column: 0)))
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
                North, NorthEast, East, SouthEast,
                South, SouthWest, West, NorthWest
            };
        }
    }
}
