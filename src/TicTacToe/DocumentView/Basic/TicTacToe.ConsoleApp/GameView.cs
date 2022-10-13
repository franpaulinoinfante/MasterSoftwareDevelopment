using TicTacToe.ConsoleApp;
using TicTacToe.Models;
using TicTacToe.Views;

internal class GameView : WithGameView
{
    public GameView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        do
        {
            new PlayerView(_game).Interact();
            _game.Next();
            new BoardView().Write(_game);
        } while (!_game.IsTicTacToe());
        new MessageView(MessageType.PLAYER_WIN).WriteLine(_game.CurrentPlayer.ToString());
    }
}