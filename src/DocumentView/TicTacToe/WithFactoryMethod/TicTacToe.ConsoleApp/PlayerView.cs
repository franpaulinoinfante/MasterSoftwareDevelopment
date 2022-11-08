using System.Diagnostics;
using TicTacToe.Models;
using TicTacToe.Types;
using TicTacToe.Views;

internal class PlayerView
{
    private readonly Game _game;

    public PlayerView(Game game)
    {
        _game = game;
    }

    protected internal void Interact()
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
        ErrorType errorCode;
        do
        {
            coordinate = GetCoordinate(MessageType.ENTER_COORDINATE_TO_PUT);
            errorCode = GetErrorCodeToPutToken(coordinate);
        } while (errorCode != ErrorType.NULL);
        _game.PutToken(coordinate);
    }

    private Coordinate GetCoordinate(MessageType messageType)
    {
        return new CoordinateView().Read(messageType);
    }

    protected virtual ErrorType GetErrorCodeToPutToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        ErrorType errorCode = _game.GetErrorCodeToPut(coordinate);
        if (errorCode != ErrorType.NULL)
        {
            new ErrorView().WriteLine(errorCode);
        }
        return errorCode;
    }

    private void MoveToken()
    {
        Coordinate origin;
        ErrorType errorCode;
        do
        {
            origin = GetCoordinate(MessageType.COORDINATE_TO_REMOVE);
            errorCode = GetErrorCodeToMoveOrigin(origin);
        } while (errorCode != ErrorType.NULL);

        Coordinate target;
        do
        {
            target = GetCoordinate(MessageType.COORDINATE_TO_MOVE);
            errorCode = GetErrorCodeToMoveTarge(origin, target);
        } while (errorCode != ErrorType.NULL);
        _game.Move(origin, target);
    }

    protected virtual ErrorType GetErrorCodeToMoveOrigin(Coordinate coordinate)
    {
        Debug.Assert(!coordinate.IsNull());

        ErrorType errorCode = _game.GetErrorCodeToMoveOrigin(coordinate);
        if (errorCode != ErrorType.NULL)
        {
            new ErrorView().WriteLine(errorCode);
        }
        return errorCode;
    }

    protected virtual ErrorType GetErrorCodeToMoveTarge(Coordinate origin, Coordinate target)
    {
        Debug.Assert(!origin.IsNull() && !target.IsNull());

        ErrorType errorCode = _game.GetErrorCodeToMoveTarget(origin, target);
        if (errorCode != ErrorType.NULL)
        {
            new ErrorView().WriteLine(errorCode);
        }
        return errorCode;
    }
}