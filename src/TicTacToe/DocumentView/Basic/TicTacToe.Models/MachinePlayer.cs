using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal class MachinePlayer : Player
{
    public MachinePlayer(Token token, Board board) : base(token, board)
    {
        _playerType = PlayerType.MACHINE;
    }
}
