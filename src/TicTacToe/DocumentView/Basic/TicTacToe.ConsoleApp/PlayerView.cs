using System.Diagnostics;
using TicTacToe.Models;
using TicTacToe.Types;
using TicTacToe.Views;

internal class PlayerView
{
    private Game _game;

    public PlayerView(Game game)
    {
        _game = game;
    }

    internal void Interact()
    {
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
        Coordinate coordinate;
        ErrorCode errorCode;
        do
        {
            coordinate = GetCoordinate(MessageType.ENTER_COORDINATE_TO_PUT);
            errorCode = GetErrorCodeToPutToken(coordinate);
        } while (errorCode != ErrorCode.NULL);
    }

    private Coordinate GetCoordinate(MessageType messageType)
    {
        return (Coordinate)new CoordinateView().Read(messageType);
    }

    private ErrorCode GetErrorCodeToPutToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        ErrorCode errorCode = _game.GetErrorCodeToPut(coordinate);
        new ErrorView().WriteLine(errorCode);
        return errorCode;
    }

    private void MoveToken()
    {
        Coordinate origin;
        ErrorCode errorCode;
        do
        {
            origin = GetCoordinate(MessageType.COORDINATE_TO_REMOVE);
            errorCode = GetErrorCodeToMoveOrigin(origin);
        } while (errorCode != ErrorCode.NULL);

        Coordinate target;
        do
        {
            target = GetCoordinate(MessageType.COORDINATE_TO_MOVE);
            errorCode = GetErrorCodeToMoveTarge(origin, target);
        } while (errorCode != ErrorCode.NULL);
        _game.Move(origin, target);
    }

    private ErrorCode GetErrorCodeToMoveOrigin(Coordinate coordinate)
    {
        Debug.Assert(!coordinate.IsNull());

        ErrorCode errorCode = _game.GetErrorCodeToMoveOrigin(coordinate);
        new ErrorView().WriteLine(errorCode);
        return errorCode;
    }

    private ErrorCode GetErrorCodeToMoveTarge(Coordinate origin, Coordinate target)
    {
        Debug.Assert(!origin.IsNull() && !target.IsNull());

        ErrorCode errorCode = _game.GetErrorCodeToMoveTarget(origin, target);
        new ErrorView().WriteLine(errorCode);
        return errorCode;
    }
}