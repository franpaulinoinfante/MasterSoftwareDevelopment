namespace ConnectFourConsoleApp.Models;

internal class Turn
{
    private Player[] _players;
    private readonly Board _board;

    private int _current;

    public Turn(Board board)
    {
        _board = board;
        _players = new Player[PlayerCreator.MaxPlayers];
        Reset();
    }

    internal void Reset()
    {
        for (int i = 0; i < PlayerCreator.MaxPlayers; i++)
        {
            _players[i] = PlayerCreator.Instance.CreatePlayers(i, _board);
        }

        _current = new Random().Next(minValue: 0, PlayerCreator.MaxPlayers);
    }

    internal void Play()
    {
        _players[_current].Play();
        if (!_board.IsFinished())
        {
            _current = (_current + 1) % PlayerCreator.MaxPlayers;
        }
    }

    internal void WriteResult()
    {
        throw new NotImplementedException();
    }
}