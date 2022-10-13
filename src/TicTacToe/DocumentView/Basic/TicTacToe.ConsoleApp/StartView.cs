using TicTacToe.Models;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp
{
    internal class StartView : WithGameView
    {
        public StartView(Game game) : base(game)
        {

        }

        internal void Interact()
        {
            new MessageView().WriteLine(MessageType.TITLE);
            new BoardView().Write(_game);
        }
    }
}
