using ConnectFour.Types;
using ConnectFour.Utils;

namespace ConnectFour.Models;

internal class Board
{
    private readonly Token[,] _tokens;
    private Coordinate? _lastDrop;

    public Board()
    {
        _tokens = new Token[Coordinate.MaxRows, Coordinate.MaxColumns];
        //NewGame();
    }

    public void NewGame()
    {
        for (int i = 0; i < Coordinate.MaxRows; i++)
        {
            for (int j = 0; j < Coordinate.MaxColumns; j++)
            {
                _tokens[i, j] = Token.Null;
            }
        }
    }

    internal void Drop(int colunm, Token token)
    {
        _lastDrop = GetLastDrop(colunm);
        if (!IsEmpty(_lastDrop))
        {
            _lastDrop.Row--;
        }

        _tokens[_lastDrop.Row, _lastDrop.Column] = token;
    }

    private Coordinate GetLastDrop(int colunm)
    {
        Coordinate coordinate = new Coordinate(row: 0, colunm);
        while ((coordinate.Row < Coordinate.MaxRows - 1) && IsEmpty(coordinate))
        {
            coordinate = coordinate.Shifted(new Coordinate(row: 1, column: 0)) ;
        }

        return coordinate;
    }

    private bool IsEmpty(Coordinate coordinate)
    {
        return IsOccupied(coordinate, Token.Null);
    }

    private bool IsOccupied(Coordinate coordinate, Token token)
    {
        return GetToken(coordinate) == token;
    }

    internal Token GetToken(Coordinate coordinate)
    {
        return _tokens[coordinate.Row, coordinate.Column];
    }

    internal bool IsComplete(int colunm)
    {
        return !IsEmpty(new Coordinate(row: 0, colunm));
    }

    internal bool IsFinished()
    {
        return IsWinner() || IsComplete();
    }

    private bool IsComplete()
    {
        for (int i = 0; i < Coordinate.MaxRows; i++)
        {
            for (int j = 0; j < Coordinate.MaxColumns; j++)
            {
                if (IsEmpty(new Coordinate(i, j)))
                {
                    return false;
                }
            }
        }

        return true;
    }

    internal bool IsWinner()
    {
        Line line = new Line(_lastDrop);
        foreach (Direction direction in Direction.Directions.GetRange(index: 0, count: 3))
        {
            line.Direction = direction;
            for (int i = 0; i < Line.Length; i++)
            {
                if (IsConnectFour(line))
                {
                    return true;
                }

                line.Shift();
            }
        }

        return false;
    }

    private bool IsConnectFour(Line line)
    {
        Coordinate[] coordinates = line.Coordinates;
        for (int i = 0; i < Line.Length; i++)
        {
            if (!coordinates[i].IsIncluided())
            {
                return false;
            }
            if ((i > 0) && GetToken(coordinates[i - 1]) != GetToken(coordinates[i]))
            {
                return false;
            }
        }

        return true;
    }
}