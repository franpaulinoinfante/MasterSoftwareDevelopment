using ConnectFourConsoleApp.Types;
using ConnectFourConsoleApp.Utils;

namespace ConnectFourConsoleApp.Models.Players;

internal class MachinePlayer : Player
{
    public MachinePlayer(Board board, Token token) : base(token, board)
    {
    }

    protected override int ReadColunm()
    {
        int colunm;
        do
        {
            colunm = new Random().Next(minValue: 0, Coordinate.MaxColunms);
        } while (Board.IsComplete(colunm));
        Message.Random.WriteLine(colunm);
        Task.Delay(600).Wait();
        return colunm;
    }
}