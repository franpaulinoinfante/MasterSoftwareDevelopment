using TicTacToe.Models;
using TicTacToe.Models.Types;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp.UseCaseView.PlayerViews;

internal abstract class PlayerView
{
    private Game? _game;

    internal void Interact(Game game)
    {
        _game = game;
        if (!_game.AreAllTokenOnBoard())
        {
            PutToken();
        }
        else
        {
            MoveToken();
        }
    }

    private void PutToken()
    {
        ErrorType errorType;
        Coordinate coordinate;
        do
        {
            coordinate = GetCoordinate(MessageType.COORDINATE_TO_PUT);
            errorType = GetErrorTypeToPut(coordinate);
        } while (errorType != ErrorType.NULL);
        _game.PutToken(coordinate);
    }

    internal abstract Coordinate GetCoordinate(MessageType messageType);

    protected virtual ErrorType GetErrorTypeToPut(Coordinate coordinate)
    {
        return _game.GetErrorTypeToPut(coordinate);
    }

    private void MoveToken()
    {
        ErrorType errorType;
        Coordinate origin;
        do
        {
            origin = GetCoordinate(MessageType.COORDINATE_TO_REMOVE);
            errorType = GetErrorTypeToMoveOrigin(origin);
        } while (errorType != ErrorType.NULL);

        Coordinate target;
        do
        {
            target = GetCoordinate(MessageType.COORDINATE_TO_MOVE);
            errorType = GetErrorTypeToMoveTarge(origin, target);
        } while (errorType != ErrorType.NULL);
        _game.MoveToken(origin, target);
    }

    protected virtual ErrorType GetErrorTypeToMoveOrigin(Coordinate coordinate)
    {
        return _game.GetErrorTypeToMoveOrigin(coordinate);
    }

    protected virtual ErrorType GetErrorTypeToMoveTarge(Coordinate origin, Coordinate target)
    {
        return _game.GetErrorTypeToMoveTarge(origin, target);
    }
}