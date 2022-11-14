using ConnectFourConsoleApp.Models.Players;
using ConnectFourConsoleApp.Types;

namespace ConnectFourConsoleApp.Models;

internal class Turn
{
    internal const int MaxPlayers = 2;

    private readonly Player[] _players;
    private readonly Board _board;

    private int _current;

    public Turn(Board board)
    {
        _board = board;
        _players = new Player[Turn.MaxPlayers];
    }

    internal void SetUp(int numOfPlayers)
    {
        for (int i = 0; i < Turn.MaxPlayers; i++)
        {
            _players[i] = PlayerCreator.Instance.Create(i, numOfPlayers, _board);
        }
        _current = new Random().Next(minValue: 0, Turn.MaxPlayers);
    }

    internal void Play()
    {
        _players[_current].Play();
        if (!_board.IsFinished())
        {
            _current = (_current + 1) % Turn.MaxPlayers;
        }
    }

    internal void WriteResult()
    {
        if (_board.IsWinner())
        {
            _players[_current].WriteWinner();
        }
        else
        {
            Message.PlayersTied.WriteLine();
        }
    }
}