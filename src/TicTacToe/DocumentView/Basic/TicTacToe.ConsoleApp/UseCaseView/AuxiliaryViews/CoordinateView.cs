using TicTacToe.ConsoleApp.ConsolesIOs;
using TicTacToe.Models.Types;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews
{
    internal class CoordinateView
    {
        internal Coordinate Read(MessageType messageType)
        {
            new MessageView(messageType).WriteLine();
            ErrorType errorType;
            Coordinate coordinate;
            do
            {
                int row = ConsoleIO.GetInstance().ReadInt($"{Coordinate.ROW}") - 1;
                int colunm = ConsoleIO.GetInstance().ReadInt($"{Coordinate.COLUMN}") - 1;
                coordinate = new Coordinate(row, colunm);
                errorType = GetErrorTypeToReadCoordinate(coordinate);
                new ErrorView(errorType).WriteLine();
            } while (errorType != ErrorType.NULL);
            return coordinate;
        }

        private ErrorType GetErrorTypeToReadCoordinate(Coordinate coordinate)
        {
            Coordinate a = new Coordinate();

            if (!coordinate.IsValid())
            {
                return ErrorType.WRONG_COORDINATE;
            }
            return ErrorType.NULL;
        }

        internal Coordinate ReadRandom(MessageType messageType)
        {
            return new Coordinate().Random();
        }
    }
}