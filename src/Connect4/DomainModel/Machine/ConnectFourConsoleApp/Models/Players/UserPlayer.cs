using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Types;
using ConnectFourConsoleApp.Utils;

namespace ConnectFourConsoleApp.Models.Players;

internal class UserPlayer : Player
{
    public UserPlayer(Board board, Token token) : base(token, board)
    {
    }

    protected override int ReadColunm()
    {
        int colunm;
        bool isValid;
        do
        {
            colunm = ConsoleIO.Instance.ReadInt(Message.EnterColunmToDrop.GetMessage()) - 1;
            isValid = new Coordinate(Coordinate.MaxRows, Coordinate.MaxColunms).IsValid(colunm);
            if (!isValid)
            {
                Message.InvalidColunm.WriteLine();
            }
            else
            {
                isValid = !Board.IsComplete(colunm);
                if (!isValid)
                {
                    Message.CompleteColunm.WriteLine();
                }
            }
        } while (!isValid);
        return colunm;
    }
}