using ConnectFour.GameViews;
using ConnectFour.Models;
using ConnectFour.Types;
using ConnectFour.Utils;

internal class BoardView
{
    internal void Write(Game game)
    {
        new MessageView().WriteLine(Message.HorizontalLine);
        for (int i = 0; i < Coordinate.MaxRows; i++)
        {
            new MessageView().Write(Message.VerticalLine);
            for (int j = 0; j < Coordinate.MaxColumns; j++)
            {
                ConsoleIO.Instance.Write(game.GetToken(new Coordinate(i, j)).GetToString());
                new MessageView().Write(Message.VerticalLine);
            }
            ConsoleIO.Instance.WriteLine();
        }
        new MessageView().WriteLine(Message.HorizontalLine);
    }
}