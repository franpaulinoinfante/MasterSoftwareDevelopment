using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Models.Types;

namespace ConnectFourConsoleApp.Models;

internal abstract class Player
{
    private readonly Token _token;
    private readonly Board _board;

    public Player(Token token, Board board)
    {
        _token = token;
        _board = board;
    }

    internal Token Token { get => _token; }
    internal Board Board { get => _board; }

    internal void Play()
    {
        Message.Turn.Write();
        ConsoleIO.Instance.WriteLine(_token.ToString());
        int colunm = ReadColunm();
        _board.Drop(colunm, _token);
    }

    protected abstract int ReadColunm();

    internal void WriteWinner()
    {
        string message = Message.PlayerWin.GetMessage();
        message = message.Replace("#token", _token.ToString());
        ConsoleIO.Instance.WriteLine(message);
    }
}