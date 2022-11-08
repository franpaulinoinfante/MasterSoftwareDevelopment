namespace TicTacToe.Utils.Coordinates
{
    public interface ICoordinate
    {
        public static NullCoordinate NULL = NullCoordinate.GetInstante();
        public bool IsNull();
        public Direction GetDirection(ICoordinate coordinate);
        public bool IsInHorizonal(ICoordinate coordinate);
        public bool IsInVertical(ICoordinate coordinate);
        public bool IsInMainDiagonal();
    }
}
