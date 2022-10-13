using System.Diagnostics;
using TicTacToe.Types;

namespace TicTacToe.Models
{
    internal class Player
    {
        private readonly Token _token;
        private readonly Board _board;

        public Token Token { get; internal set; }

        public Player(Token tokens, Board board)
        {
            _token = tokens;
            _board = board;
        }

        internal void PutToken(Coordinate coordinate)
        {
            Debug.Assert(!_board.IsComplete(_token));

            _board.PutToken(coordinate, _token);
        }

        internal ErrorCode GetErrorCodeToMoveOrigin(Coordinate coordinate)
        {
            if (!_board.IsEmpty(coordinate))
            {
                return ErrorCode.NOT_EMPTY;
            }
            return ErrorCode.NULL;
        }

        internal void Move(Coordinate origin, Coordinate target)
        {
            _board.Move(origin, target);
        }
    }
}