using TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;
using TicTacToe.Models.Types;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp.UseCaseView.PlayerViews;

internal class UserPlayerView : PlayerView
{
    internal override Coordinate GetCoordinate(MessageType messageType)
    {
        return new CoordinateView().Read(messageType);
    }

    protected override ErrorType GetErrorTypeToPut(Coordinate coordinate)
    {
        ErrorType errorType = base.GetErrorTypeToPut(coordinate);
        new ErrorView(errorType).WriteLine();
        return errorType;
    }

    protected override ErrorType GetErrorTypeToMoveOrigin(Coordinate origin)
    {
        ErrorType errorType = base.GetErrorTypeToMoveOrigin(origin);
        new ErrorView(errorType).WriteLine();
        return errorType;
    }

    protected override ErrorType GetErrorTypeToMoveTarge(Coordinate origin, Coordinate target)
    {
        ErrorType errorType = base.GetErrorTypeToMoveTarge(origin, target);
        new ErrorView(errorType).WriteLine();
        return errorType;
    }
}
