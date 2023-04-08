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

    internal void Drop(int column)
    {
        _board.Drop(column, _token);
    }

    internal Error GetErrorToDrop(int column)
    {
        if (_board.IsComplete(column))
        {
            return Error.TheColunmIsComplete;
        }

        return Error.Null;
    }
}