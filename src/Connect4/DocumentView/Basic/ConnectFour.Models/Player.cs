using ConnectFour.Types;

namespace ConnectFour.Models;

internal class Player
{
    private Token _token;
    private Board _board;
    private PlayerType _playerType;

    public Player(Token token, Board board, PlayerType userPlayer)
    {
        _token = token;
        _board = board;
        _playerType = userPlayer;
    }

    public Token Token => _token;
    public PlayerType PlayerType => _playerType;

    internal void Drop(int colunm)
    {
        _board.Drop(colunm, _token);
    }

    internal Error GetErrorToDrop(int colunm)
    {
        if (_board.IsComplete(colunm))
        {
            return Error.ColunmIsComplete;
        }
        return Error.Null;
    }
}