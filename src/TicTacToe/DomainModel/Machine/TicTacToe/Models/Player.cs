namespace TicTacToe.Models;

internal abstract class Player
{
    protected Token _token;
    protected Board _board;
    private int _tokensPlaced;

    public Player(Board board, Token token)
    {
        _board = board;
        _token = token;
        _tokensPlaced = 0;
    }

    protected internal int TokensPlaced => _tokensPlaced;

    protected internal Token Token => _token;

    protected internal void Play()
    {
        if (_tokensPlaced < Coordinate.DIMENSION)
        {
            PutToken();
        }
        else
        {
            MoveToken();
        }
    }

    protected internal void PutToken()
    {
        ErrorType errorType;
        Coordinate coordinate;
        do
        {
            coordinate = ReadCoordinate(MessageType.ENTER_COORDINATE_TO_PUT);
            errorType = GetErrorTypeToPut(coordinate);
        } while (errorType != ErrorType.NULL);
        _board.PutToken(coordinate, _token);
        _tokensPlaced++;
    }

    protected abstract Coordinate ReadCoordinate(MessageType messageType);

    protected virtual ErrorType GetErrorTypeToPut(Coordinate coordinate)
    {
        if (!_board.IsOccupied(coordinate, Token.NULL))
        {
            return ErrorType.IS_NOT_EMPTY;
        }
        return ErrorType.NULL;
    }

    protected internal void MoveToken()
    {
        ErrorType errorType;
        Coordinate origin;
        do
        {
            origin = ReadCoordinate(MessageType.COORDINATE_TO_REMOVE);
            errorType = GetErrorTypeToMoveOrigin(origin);
        } while (errorType != ErrorType.NULL);

        Coordinate target;
        do
        {
            target = ReadCoordinate(MessageType.COORDINATE_TO_MOVE);
            errorType = GetErrorTypeToMoveTarget(origin, target);
        } while (errorType != ErrorType.NULL);
        _board.MoveToken(origin, target);
    }

    protected virtual ErrorType GetErrorTypeToMoveOrigin(Coordinate origin)
    {
        if (!_board.IsOccupied(origin, _token))
        {
            return ErrorType.NOT_OWNER;
        }
        return ErrorType.NULL;
    }

    protected virtual ErrorType GetErrorTypeToMoveTarget(Coordinate origin, Coordinate target)
    {
        if (origin.Equals(target))
        {
            return ErrorType.SAME_COORDINATE;
        }
        if (!_board.IsOccupied(target, Token.NULL))
        {
            return ErrorType.IS_NOT_EMPTY;
        }
        return ErrorType.NULL;
    }

    protected internal void SingVictory()
    {
        new Message(MessageType.WINNER).WriteLine(_token.ToString());
    }
}