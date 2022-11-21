using TicTacToe.Models;
using TicTacToe.Types;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp;

internal class BoardView
{
    internal void Write(Game game)
    {
        MessageView messageView = new MessageView();
        messageView.WriteLine(MessageType.HORIZONTAL_LINE);
        for (int i = 0; i < Coordinate.DIMENSION; i++)
        {
            messageView.Write(MessageType.VERTICAL_LINE);
            for (int j = 0; j < Coordinate.DIMENSION; j++)
            {
                new TokenView().Write(game.GetToken(new Coordinate(i, j)));
                messageView.Write(MessageType.VERTICAL_LINE);
            }
            ConsoleIO.GetInstance().WriteLine();
        }
        messageView.WriteLine(MessageType.HORIZONTAL_LINE);
    }
}