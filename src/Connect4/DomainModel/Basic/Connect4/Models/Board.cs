using Connect4.ConsoleIOs;
using Connect4.Models.Types;

namespace Connect4.Models;

internal class Board
{
    private readonly Token[,] _tokens;
    private Coordinate? _lastDrop;

    public Board()
    {
        _tokens = new Token[Coordinate.NumberRows, Coordinate.NumberColunms];
        Reset();
    }

    internal void Reset()
    {
        for (int i = 0; i < Coordinate.NumberRows; i++)
        {
            for (int j = 0; j < Coordinate.NumberColunms; j++)
            {
                _tokens[i, j] = Token.Null;
            }
        }
    }

    internal void Drop(Token token, int colunm)
    {
        _lastDrop = GetLastDrop(colunm);
        if (!IsEmpty(_lastDrop))
        {
            _lastDrop.Row--;
        }
        _tokens[_lastDrop.Row, _lastDrop.Colunm] = token;
    }

    private Coordinate GetLastDrop(int colunm)
    {
        _lastDrop = new Coordinate(row: 0, colunm);
        while ((_lastDrop.Row < Coordinate.NumberRows - 1) && IsEmpty(_lastDrop))
        {
            _lastDrop = _lastDrop.Shifted(Direction.North.Coordinate);
        }
        return _lastDrop;
    }

    private bool IsEmpty(Coordinate coordinate)
    {
        return IsOccupied(coordinate, Token.Null);
    }

    private bool IsOccupied(Coordinate coordinate, Token token)
    {
        return GetToken(coordinate) == token;
    }

    private Token GetToken(Coordinate coordinate)
    {
        return _tokens[coordinate.Row, coordinate.Colunm];
    }

    internal bool IsComplete(int colunm)
    {
        return !IsEmpty(new Coordinate(row: 0, colunm));
    }

    internal bool IsFinished()
    {
        return IsComplete() || IsWinner();
    }

    private bool IsComplete()
    {
        for (int i = 0; i < Coordinate.NumberRows; i++)
        {
            for (int j = 0; j < Coordinate.NumberColunms; j++)
            {
                if (_tokens[i, j] == Token.Null)
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
        foreach (Direction direction in Direction.Directions().GetRange(index: 0, 3))
        {
            line.Direction = direction;
            for (int i = 0; i < Line.Length; i++)
            {
                if (IsConnect4(line))
                {
                    return true;
                }
                line.Shift();
            }
        }
        return false;
    }

    private bool IsConnect4(Line line)
    {
        Coordinate[] coordinates = line.Coordinates;
        for (int i = 0; i < Line.Length; i++)
        {
            if (!coordinates[i].IsValid())
            {
                return false;
            }
            if (i > 0 && GetToken(coordinates[i - 1]) != GetToken(coordinates[i]))
            {
                return false;
            }
        }
        return true;
    }

    internal void Write()
    {
        WriteHorizontal();
        for (int i = 0; i < Coordinate.NumberRows; i++)
        {
            Message.VerticalLine.Write();
            for (int j = 0; j < Coordinate.NumberColunms; j++)
            {
                GetToken(new Coordinate(i, j)).Write();
                Message.VerticalLine.Write();
            }
            ConsoleIO.Instance.WriteLine();
        }
        WriteHorizontal();
    }

    private void WriteHorizontal()
    {
        for (int i = 0; i < 3 * Coordinate.NumberColunms; i++)
        {
            Message.HorizontalLine.Write();
        }
        Message.HorizontalLine.WriteLine();
    }
}
