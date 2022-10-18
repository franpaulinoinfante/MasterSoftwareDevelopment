using TicTacToe.ConsoleApp.ConsolesIOs;
using TicTacToe.Models;
using TicTacToe.Models.Types;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;

internal class BoardView
{
    internal void Write(Game game)
    {
        MessageView messageView = new MessageView(MessageType.HORIZONTAL_LINE);
        messageView.WriteLine();
        for (int i = 0; i < Coordinate.DIMENSION; i++)
        {
            messageView.Write(MessageType.VERTICAL_LINE);
            for (int j = 0; j < Coordinate.DIMENSION; j++)
            {
                ConsoleIO.GetInstance().Write(new TokenView(game.GetToken(new Coordinate(i, j))).ToString());
                messageView.Write(MessageType.VERTICAL_LINE);
            }
            ConsoleIO.GetInstance().WriteLine();
        }
        messageView.WriteLine(MessageType.HORIZONTAL_LINE);
    }
}