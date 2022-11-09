using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Models.Types;

namespace ConnectFourConsoleApp.Models;

internal class UserPlayer : Player
{
    public UserPlayer(Token token, Board board) : base(token, board)
    {
    }

    protected override int ReadColunm()
    {
        int colunm;
        bool isValid;
        do
        {
            colunm = ConsoleIO.Instance.ReadInt(Message.EnterColunmToDrop.GetMessage()) - 1;
            isValid = new Coordinate(Coordinate.Rows, Coordinate.Colunms).IsValid(colunm);
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