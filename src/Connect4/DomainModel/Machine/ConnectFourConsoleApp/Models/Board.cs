using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Models.Types;

namespace ConnectFourConsoleApp.Models;

internal class Board
{
    private readonly Token[,] _tokens;
    private Coordinate? _lastDrop;

    public Board()
    {
        _tokens = new Token[Coordinate.MaxRows, Coordinate.MaxColunms];
        Reset();
    }

    internal void Reset()
    {
        for (int i = 0; i < Coordinate.MaxRows; i++)
        {
            for (int j = 0; j < Coordinate.MaxColunms; j++)
            {
                _tokens[i, j] = Token.Null;
            }
        }
    }

    internal void Drop(int colunm, Token token)
    {
        _lastDrop = GetLastDrop(colunm);
        if (!IsOccupied(_lastDrop, Token.Null))
        {
            _lastDrop.Row--;
        }
        _tokens[_lastDrop.Row, _lastDrop.Colunm] = token;
    }

    private Coordinate GetLastDrop(int colunm)
    {
        Coordinate coordinate = new Coordinate(rows: 0, colunm);
        while ((coordinate.Row < Coordinate.MaxRows - 1) && IsOccupied(coordinate, Token.Null))
        {
            coordinate = coordinate.Shifted(new Coordinate(rows: 1, colunms: 0));
        }
        return coordinate;
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
        return !IsOccupied(new Coordinate(rows: 0, colunm), Token.Null);
    }

    internal bool IsFinished()
    {
        return IsComplete() || IsWinner();
    }

    private bool IsComplete()
    {
        for (int i = 0; i < Coordinate.MaxRows; i++)
        {
            for (int j = 0; j < Coordinate.MaxColunms; j++)
            {
                if (IsOccupied(new Coordinate(i, j), Token.Null))
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
        foreach (Direction direction in Direction.Directions.GetRange(index: 0, 3))
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
            if (!coordinates[i].IsValid())
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

    internal void Write()
    {
        WriteHorizontal();
        for (int i = 0; i < Coordinate.MaxRows; i++)
        {
            Message.VerticalLine.Write();
            for (int j = 0; j < Coordinate.MaxColunms; j++)
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
        for (int i = 0; i < 3 * Coordinate.MaxColunms; i++)
        {
            Message.HorizontalLine.Write();
        }
        Message.HorizontalLine.WriteLine();
    }
}