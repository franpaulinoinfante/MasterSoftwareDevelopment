using System.Diagnostics;

namespace TicTacToe.Models
{
    internal class UserPlayer : Player
    {
        public UserPlayer(Board board, Token token) : base(board, token)
        {
        }

        protected override Coordinate ReadCoordinate(MessageType messageType)
        {
            return new Coordinate().Read(messageType);
        }

        protected override ErrorType GetErrorTypeToPut(Coordinate coordinate)
        {
            Debug.Assert(coordinate != null);

            ErrorType errorType = base.GetErrorTypeToPut(coordinate);
            new Error(errorType).WriteLine();
            return errorType;
        }

        protected override ErrorType GetErrorTypeToMoveOrigin(Coordinate origin)
        {
            Debug.Assert(origin != null);

            ErrorType errorType = base.GetErrorTypeToMoveOrigin(origin);
            new Error(errorType).WriteLine();
            return errorType;
        }

        protected override ErrorType GetErrorTypeToMoveTarget(Coordinate origin, Coordinate target)
        {
            Debug.Assert((origin != null) && (target != null));

            ErrorType errorType = base.GetErrorTypeToMoveTarget(origin, target);
            new Error(errorType).WriteLine();
            return errorType;
        }
    }
}
