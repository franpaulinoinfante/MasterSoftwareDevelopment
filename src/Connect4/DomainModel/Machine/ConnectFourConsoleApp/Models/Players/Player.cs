using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Types;

namespace ConnectFourConsoleApp.Models.Players;

internal abstract class Player
{
    private readonly Token _token;
    private readonly Board _board;

    public Player(Token token, Board board)
    {
        _token = token;
        _board = board;
    }

    protected Token Token { get => _token; }

    protected Board Board { get => _board; }

    protected internal void Play()
    {
        Message.Turn.WriteLine(_token.ToString());
        int colunm = ReadColunm();
        _board.Drop(colunm, _token);
    }

    protected abstract int ReadColunm();

    protected internal void WriteWinner()
    {
        string message = Message.PlayerWin.GetMessage();
        message = message.Replace("#token", _token.ToString());
        ConsoleIO.Instance.WriteLine(message);
    }
}