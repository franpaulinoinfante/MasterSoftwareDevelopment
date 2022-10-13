namespace TicTacToe.Utils.Coordinates
{
    public class ConcreteCoordinate : ICoordinate
    {
        public static string ROW = "Row: ";
        public static string COLUNM = "Colunm: ";

        public ConcreteCoordinate()
        {

        }

        public ConcreteCoordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; set; }

        public int Column { get; set; }

        public bool IsNull()
        {
            throw new NotImplementedException();
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
            return Row == ((ConcreteCoordinate)coordinate).Row;
        }

        public bool IsInVertical(ICoordinate coordinate)
        {
            return Column == ((ConcreteCoordinate)coordinate).Column;
        }

        public bool IsInMainDiagonal()
        {
            return Row - Column == 0;
        }
    }
}
