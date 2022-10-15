using System.Diagnostics;
using TicTacToe.ConsoleApp;
using TicTacToe.ConsoleApp.Coordinates;
using TicTacToe.Types;
using TicTacToe.Utils.Coordinates;
using TicTacToe.Views;

internal class CoordinateView
{
    internal Coordinate Read(MessageType messageType)
    {
        Debug.Assert(messageType != null);

        bool error;
        Coordinate coordinate;
        do
        {
            ConcreteCoordinate concreteCoordinate = new ConcreteCoordinateView().Read(new MessageView(messageType).ToString());
            coordinate = new Coordinate(concreteCoordinate);
            error = !coordinate.IsValid();
            if (error)
            {
                new ErrorView().WriteLine(ErrorType.WRONG_COORDINATES);
            }
        } while (error);
        return coordinate;
    }
}