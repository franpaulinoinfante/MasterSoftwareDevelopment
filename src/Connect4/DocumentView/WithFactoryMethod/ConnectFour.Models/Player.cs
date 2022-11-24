using ConnectFour.Types;

namespace ConnectFour.Models;

internal class Player
{
    private readonly Token _token;
    private readonly Board _board;
    private readonly PlayerType _playerType;

    public Player(Token token, Board board, PlayerType playerType)
    {
        _token = token;
        _board = board;
        _playerType = playerType;
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
            return Error.TheColunmIsComplete;
        }

        return Error.Null;
    }
}