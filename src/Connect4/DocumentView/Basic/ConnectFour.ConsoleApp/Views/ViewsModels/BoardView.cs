using ConnectFour.ConsoleApp.ConsoleIOs;
using ConnectFour.Models;
using ConnectFour.Utils;

namespace ConnectFour.ConsoleApp.Views.ViewsModels;
internal class BoardView
{
    internal void Write(Game game)
    {
        Message.HorizontalLine.WriteLine();
        for (int i = 0; i < Coordinate.Rows; i++)
        {
            Message.VerticalLine.Write();
            for (int j = 0; j < Coordinate.Colunms; j++)
            {
                new TokenView().Write(game.GetToken(new Coordinate(i, j)));
                Message.VerticalLine.Write();
            }
            ConsoleIO.Instance.WriteLine();
        }
        Message.HorizontalLine.WriteLine();
    }
}
