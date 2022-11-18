using ConnectFour.Types;
using ConnectFour.Utils;

namespace ConnectFour.Models;

internal class Board
{
    private Token[,] _tokens;

    public Board()
    {
        _tokens = new Token[Coordinate.Rows, Coordinate.Colunms];
        Reset();
    }

    internal void Reset()
    {
        for (int i = 0; i < Coordinate.Rows; i++)
        {
            for (int j = 0; j < Coordinate.Colunms; j++)
            {
                _tokens[i, j] = Token.Null;
            }
        }
    }

    internal void Drop(int colunm, Token token)
    {
        throw new NotImplementedException();
    }

    internal Token GetToken(Coordinate coordinate)
    {
        return _tokens[coordinate.Row, coordinate.Column];
    }

    internal bool IsComplete(int colunm)
    {
        throw new NotImplementedException();
    }

    internal bool IsFinished()
    {
        throw new NotImplementedException();
    }

    internal bool IsWinner()
    {
        throw new NotImplementedException();
    }
}