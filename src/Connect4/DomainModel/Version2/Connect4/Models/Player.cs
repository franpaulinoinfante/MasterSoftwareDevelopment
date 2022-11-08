using Connect4.ConsoleIOs;
using Connect4.Models.Types;

namespace Connect4.Models;

internal class Player
{
    private Token _token;
    private Board _board;

    public Player(Token token, Board board)
    {
        _token = token;
        _board = board;
    }

    internal void Play()
    {
        int colunm;
        bool valid;
        do
        {
            Message.Turn.Write();
            ConsoleIO.Instance.WriteLine(_token.ToString());
            colunm = ConsoleIO.Instance.ReadInt(Message.EnterColunmToDrop.GetMessage()) - 1;
            valid = Coordinate.IsColunmValid(colunm);
            if (!valid)
            {
                Message.InvalidColunm.WriteLine();
            }
            else
            {
                valid = !_board.IsComplete(colunm);
                if (!valid)
                {
                    Message.CompleteColunm.WriteLine();
                }
            }
        } while (!valid);
        _board.Drop(colunm, _token);
    }

    internal void WriteWinner()
    {
        string message = Message.PlayerWin.GetMessage();
        message = message.Replace("#token", _token.ToString());
        ConsoleIO.Instance.WriteLine(message);
    }
}