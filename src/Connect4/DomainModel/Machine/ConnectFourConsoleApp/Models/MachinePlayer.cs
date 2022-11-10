using ConnectFourConsoleApp.Models.Types;

namespace ConnectFourConsoleApp.Models;

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
        } while (!Board.IsComplete(colunm));
        Message.Random.WriteLine();
        return colunm;
    }
}