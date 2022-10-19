using System.Diagnostics;

internal class Board
{
    private readonly TokenType[,] _tokens;

    public Board()
    {
        _tokens = new TokenType[Coordinate.DIMENSION, Coordinate.DIMENSION];
        NewGame();
    }

    internal void NewGame()
    {
        for (int i = 0; i < Coordinate.DIMENSION; i++)
        {
            for (int j = 0; j < Coordinate.DIMENSION; j++)
            {
                _tokens[i, j] = TokenType.NULL;
            }
        }
    }

    internal bool AreAllTokenOnBoard(TokenType token)
    {
        Debug.Assert(token != TokenType.NULL);

        int tokens = 0;
        for (int i = 0; i < Coordinate.DIMENSION; i++)
        {
            for (int j = 0; j < Coordinate.DIMENSION; j++)
            {
                if (_tokens[i, j] == token)
                {
                    tokens++;
                }
            }
        }
        return tokens == 3;
    }

    internal void PutToken(Coordinate coordinate, TokenType token)
    {
        Debug.Assert(coordinate != null);

        _tokens[coordinate.Row, coordinate.Colunm] = token;
    }

    internal ErrorType GetErrorTypeToPut(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        if (!IsOccupied(coordinate, TokenType.NULL))
        {
            return ErrorType.IS_NOT_EMPTY;
        }
        return ErrorType.NULL;
    }

    private bool IsOccupied(Coordinate coordinate, TokenType token)
    {
        Debug.Assert(coordinate != null);

        return _tokens[coordinate.Row, coordinate.Colunm] == token;
    }

    internal void MoveToken(Coordinate origin, Coordinate target)
    {
        Debug.Assert((origin != null) && (!IsEmpty(origin)));
        Debug.Assert((target != null) && IsEmpty(target));
        Debug.Assert(!origin.Equals(target));

        TokenType token = GetToken(origin);
        PutToken(origin, TokenType.NULL);
        PutToken(target, token);
    }

    private bool IsEmpty(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return IsOccupied(coordinate, TokenType.NULL);
    }

    private TokenType GetToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return _tokens[coordinate.Row, coordinate.Colunm];
    }

    internal ErrorType GetErrorTypeToMoveOrigin(Coordinate coordinate, TokenType token)
    {
        Debug.Assert(coordinate != null);
        Debug.Assert(token != TokenType.NULL);

        if (!IsOccupied(coordinate, token))
        {
            return ErrorType.NOT_OWNER;
        }
        return ErrorType.NULL;
    }

    internal ErrorType GetErrorTypeToMoveTargetCoordinate(Coordinate origin, Coordinate target)
    {
        Debug.Assert(origin != null);
        Debug.Assert(target != null);

        bool result = origin.Equals(target);
        if (origin.Equals(target))
        {
            return ErrorType.SAME_COORDINATE;
        }
        if (!IsEmpty(target))
        {
            return ErrorType.IS_NOT_EMPTY;
        }
        return ErrorType.NULL;
    }

    internal bool IsticTacToe(TokenType token)
    {
        Debug.Assert(token != TokenType.NULL);

        List<Direction> directions = GetDirections(token);
        if (directions.Count < Coordinate.DIMENSION - 1)
        {
            return false;
        }
        else
        {
            for (int i = 0; i < directions.Count - 1; i++)
            {
                if (directions[i] != directions[i + 1])
                {
                    return false;
                }
            }
        }
        return directions[0] != Direction.NULL;
    }

    private List<Direction> GetDirections(TokenType token)
    {
        Debug.Assert(token != TokenType.NULL);

        List<Coordinate> coordinates = GetCoordinates(token);
        List<Direction> directions = new List<Direction>();
        if (coordinates.Any())
        {
            for (int i = 0; i < coordinates.Count - 1; i++)
            {
                directions.Add(coordinates[i].GetDirection(coordinates[i + 1]));
            }
        }
        return directions;
    }

    private List<Coordinate> GetCoordinates(TokenType token)
    {
        Debug.Assert(token != TokenType.NULL);

        List<Coordinate> coordinates = new List<Coordinate>();
        for (int i = 0; i < Coordinate.DIMENSION; i++)
        {
            for (int j = 0; j < Coordinate.DIMENSION; j++)
            {
                if (GetToken(new Coordinate(i, j)) == token)
                {
                    coordinates.Add(new Coordinate(i, j));
                }
            }
        }
        return coordinates;
    }

    internal void Write()
    {
        Message message = new Message(MessageType.HORIZONTAL_LINE);
        message.WriteLine();
        for (int i = 0; i < Coordinate.DIMENSION; i++)
        {
            message.Write(MessageType.VERTICAL_LINE);
            for (int j = 0; j < Coordinate.DIMENSION; j++)
            {
                ConsoleIO.GetInstance().Write(new Token(_tokens[i, j]).ToString());
                message.Write(MessageType.VERTICAL_LINE);
            }
            ConsoleIO.GetInstance().WriteLine();
        }
        message.WriteLine(MessageType.HORIZONTAL_LINE);
    }
}