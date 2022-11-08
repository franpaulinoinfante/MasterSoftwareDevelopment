using System.Diagnostics;
using TicTacToe.Types;

namespace TicTacToe.Models;

internal class Player
{
    private readonly Board _board;
    private readonly Token _token;

    public Player(Token tokens, Board board)
    {
        _token = tokens;
        _board = board;
    }

    public Token Token => _token;

    internal void PutToken(Coordinate coordinate)
    {
        Debug.Assert(!_board.AreAllTokenOnBoard(Token));

        _board.PutToken(coordinate, Token);
    }

    internal ErrorType GetErrorCodeToMoveOrigin(Coordinate coordinate)
    {
        if (!_board.IsOccupied(coordinate, _token))
        {
            return ErrorType.NOT_EMPTY;
        }
        return ErrorType.NULL;
    }

    internal void Move(Coordinate origin, Coordinate target)
    {
        _board.Move(origin, target);
    }
}