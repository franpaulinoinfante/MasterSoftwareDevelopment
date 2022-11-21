using System.Diagnostics;
using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal abstract class Player
{
    protected Token _token;
    protected Board _board;
    protected PlayerType _playerType;
    protected int placed_tokens;

    public Player(Token token, Board board)
    {
        _token = token;
        _board = board;
        placed_tokens = 0;
    }

    protected internal Token Token => _token;

    protected internal PlayerType PlayerType => _playerType;

    protected internal bool AreAllTokenOnBoard()
    {
        return placed_tokens == Coordinate.DIMENSION;
    }

    protected internal void PutToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        _board.PutToken(coordinate, _token);
        placed_tokens++;
    }

    protected internal ErrorType GetErrorTypeToPut(Coordinate coordinate)
    {
        if (!_board.IsOccupied(coordinate, Token.NULL))
        {
            return ErrorType.NOT_EMPTY;
        }
        return ErrorType.NULL;
    }

    protected internal void MoveToken(Coordinate origin, Coordinate target)
    {
        Debug.Assert((origin != null) && (!_board.IsOccupied(origin, Token.NULL)));
        Debug.Assert((target != null) && _board.IsOccupied(target, Token.NULL));
        Debug.Assert(!origin.Equals(target));

        _board.MoveTokem(origin, target);
    }

    protected internal ErrorType GetErrorTypeToMoveOrigin(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        if (!_board.IsOccupied(coordinate, _token))
        {
            return ErrorType.NOT_OWNER;
        }
        return ErrorType.NULL;
    }

    protected internal ErrorType GetErrorTypeToMoveTarget(Coordinate origin, Coordinate target)
    {
        Debug.Assert((origin != null) && (target != null));

        if (origin.Equals(target))
        {
            return ErrorType.SAME_COORDINATE;
        }
        if (!_board.IsOccupied(target, Token.NULL))
        {
            return ErrorType.NOT_EMPTY;
        }
        return ErrorType.NULL;
    }
}
