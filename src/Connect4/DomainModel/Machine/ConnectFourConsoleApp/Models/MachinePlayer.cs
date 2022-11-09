using ConnectFourConsoleApp.Models.Types;

namespace ConnectFourConsoleApp.Models;

internal class MachinePlayer : Player
{
    public MachinePlayer(Token token, Board board) : base(token, board)
    {
    }

    protected override int ReadColunm()
    {
        int colunm;
        do
        {
            colunm = new Random().Next(minValue: 0, Coordinate.Colunms);
        } while (!Board.IsComplete(colunm));
        Message.Random.WriteLine(colunm);
        return colunm;
    }
}