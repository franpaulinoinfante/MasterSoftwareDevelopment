namespace TicTacToe.Utils.Coordinates;

public class NullCoordinate : ICoordinate
{
    private static NullCoordinate? _instance;

    public static NullCoordinate GetInstante()
    {
        if (NullCoordinate._instance == null)
        {
            NullCoordinate._instance = new NullCoordinate();
        }
        return NullCoordinate._instance;
    }

    public bool IsNull()
    {
        return true;
    }

    public Direction GetDirection(ICoordinate coordinate)
    {
        return Direction.NULL;
    }

    public bool IsInHorizonal(ICoordinate coordinate)
    {
        return false;
    }

    public bool IsInVertical(ICoordinate coordinate)
    {
        return false;
    }

    public bool IsInMainDiagonal()
    {
        return false;
    }
}
