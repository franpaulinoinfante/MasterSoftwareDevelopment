using ConnectFour.Types;

namespace ConnectFour.Models;

internal class Turn
{
    private static int MaxPlayer = 2;

    private Player[] _players;
    private Board _board;

    private int _current;

    public Turn(Board board)
    {
        _board = board;
        _players = new Player[Turn.MaxPlayer];
        _current = Change();
    }

    public Token ActivePlayer => _players[_current].Token;
    public Token LastPlayer => _players[Change()].Token;
    public PlayerType PlayerType => _players[_current].PlayerType;

    internal void SetPlayers(int numOfPlayers)
    {
        for (int i = 0; i < numOfPlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], _board, PlayerType.UserPlayer);
        }
        for (int i = numOfPlayers; i < Turn.MaxPlayer; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], _board, PlayerType.MachinePlayer);
        }
    }

    internal void Next()
    {
        _current = Change();
    }

    private int Change()
    {
        return (_current + 1) % Turn.MaxPlayer;
    }

    internal void Drop(int colunm)
    {
        _players[_current].Drop(colunm);
    }

    internal Error GetErrorToDrop(int colunm)
    {
        return _players[_current].GetErrorToDrop(colunm);
    }

    internal Error GetErrorToSetNumOfPlayers(int players)
    {
        if (players >= 0 && players <= Turn.MaxPlayer)
        {
            return Error.Null;
        }
        return Error.NumOfPlayerOutOfRange;
    }
}