using ConnectFourConsoleApp;
using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Models.Types;
using ConnectFourConsoleApp.Types;
using System.Diagnostics;

internal class Board
{
    private const int Row = 0;

    private readonly Token[,] _tokens;

    public Board()
    {
        _tokens = new Token[Coordinate.ROW, Coordinate.COLUNM];
        Reset();
    }

    internal void Reset()
    {
        for (int i = 0; i < Coordinate.ROW; i++)
        {
            for (int j = 0; j < Coordinate.COLUNM; j++)
            {
                _tokens[i, j] = Token.Null;
            }
        }
    }

    internal void Insert(int colunmToInsert, Token token)
    {
        Debug.Assert(!token.IsNull() && !IsOccupied(colunmToInsert));

        _tokens[GetRowToInsert(colunmToInsert), colunmToInsert] = token;
    }

    private int GetRowToInsert(int colunmToInsert)
    {
        Debug.Assert(!IsOccupied(colunmToInsert));

       int i = 0;
        while ((i < Coordinate.ROW - 1) && (_tokens[i, colunmToInsert] == Token.Null))
        {
            i++;
        }
        if (_tokens[i, colunmToInsert] != Token.Null)
        {
            i--;
        }
        return i;
    }

    internal bool IsOccupied(int colunmToInsert)
    {
        return _tokens[Row, colunmToInsert] != Token.Null;
    }

    internal bool IsTie()
    {
        for (int i = 0; i < Coordinate.ROW; i++)
        {
            for (int j = 0; j < Coordinate.COLUNM; j++)
            {
                if (_tokens[i, j] == Token.Null)
                {
                    return false;
                }
            }
        }
        return true;
    }

    internal bool IsWinner(Token token)
    {
        Debug.Assert(!token.IsNull());

        List<Direction> directions = GetDirections(token);
        if (directions.Count < 3)
        {
            return false;
        }
        else
        {
            for (int i = 0; i < directions.Count - 1; i++)
            {
                if (directions[i] == directions[i + 1])
                {

                }
            }
        }
        return false;
    }

    private List<Direction> GetDirections(Token token)
    {
        Debug.Assert(!token.IsNull());

        List<Coordinate> coordinates = GetCoordinate(token);
        List<Direction> directions = new List<Direction>();
        if (coordinates.Any())
        {
            for (int i = 0; i < coordinates.Count - 1; i++)
            {
                for (int j = i + 1; j < coordinates.Count - 1; j++)
                {
                    directions.Add(coordinates[i].GetDirection(coordinates[j]));
                }
            }
        }
        return directions;
    }

    private List<Coordinate> GetCoordinate(Token token)
    {
        Debug.Assert(!token.IsNull());

        List<Coordinate> coordinates = new List<Coordinate>();
        for (int i = 0; i < Coordinate.ROW; i++)
        {
            for (int j = 0; j < Coordinate.COLUNM; j++)
            {
                if (GetToken(new Coordinate(i, j)) == token)
                {
                    coordinates.Add(new Coordinate(i, j));
                }
            }
        }
        return coordinates;
    }

    private Token GetToken(Coordinate coordinate)
    {
        Debug.Assert(coordinate != null);

        return _tokens[coordinate.Row, coordinate.Colunm];
    }

    internal void Write()
    {
        MessageCode.HorizontalLine.WriteLine();
        for (int i = 0; i < Coordinate.ROW; i++)
        {
            MessageCode.VerticalLine.Write();
            for (int j = 0; j < Coordinate.COLUNM; j++)
            {
                _tokens[i, j].Write();
                MessageCode.VerticalLine.Write();
            }
            ConsoleIO.GetInstance().WriteLine();
        }
        MessageCode.HorizontalLine.WriteLine();
    }
}