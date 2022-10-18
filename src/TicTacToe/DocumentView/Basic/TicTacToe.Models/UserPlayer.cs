using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal class UserPlayer : Player
{
    public UserPlayer(Token token, Board board) : base(token, board)
    {
        _playerType = PlayerType.USER;
    }
}
