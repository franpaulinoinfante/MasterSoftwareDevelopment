using Connect4.Models.Types;

namespace Connect4.Models;

internal class Turn
{
    private const int NumberOfPlayers = 2;

    private readonly Board _board;
    private readonly Player[] _players;

    private int _current;

    public Turn(Board board)
    {
        _board = board;
        _players = new Player[NumberOfPlayers];
        Reset();
    }

    internal void Reset()
    {
        for (int i = 0; i < Turn.NumberOfPlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], _board);
        }
        _current = new Random().Next(minValue: 0, Turn.NumberOfPlayers);
    }

    internal void Play()
    {
        _players[_current].Play();
        if (!_board.IsFinished())
        {
            _current = (_current + 1) % Turn.NumberOfPlayers;
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
            Message.Titile.WriteLine();
        }
    }
}
