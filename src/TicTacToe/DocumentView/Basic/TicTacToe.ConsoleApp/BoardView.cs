using TicTacToe.Models;

namespace TicTacToe.ConsoleApp
{
    internal class BoardView
    {
        public BoardView()
        {
        }

        internal void Write(Game game)
        {
            MessageView messageView = new MessageView();
            messageView.WriteLine(Views.MessageType.HORIZONTAL_LINE);
        }
    }
}