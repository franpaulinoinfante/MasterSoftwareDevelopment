using ConnectFour.Types;

namespace ConnectFour.Models;

internal class Turn
{
    internal static int MaxPlayers = 2;
    internal static int MinPlayers = 0;

    private readonly Player[] _players;
    private int _current;

    public Turn(Player[] players)
    {
        _players = players;
        _current = 0;
    }

    internal Player CurrentPlayer => _players[_current];

    public Player GetLastPlayer => _players[Change()];

    private int Change()
    {
        return (_current + 1) % Turn.MaxPlayers;
    }

    internal Error GetErrorToSetUpNumOfPlayer(int players)
    {
        if (players < Turn.MinPlayers || players > Turn.MaxPlayers)
        {
            return Error.ThePlayersIsOutOfRange;
        }

        return Error.Null;
    }

    internal void Next()
    {
        _current = Change();
    }
}