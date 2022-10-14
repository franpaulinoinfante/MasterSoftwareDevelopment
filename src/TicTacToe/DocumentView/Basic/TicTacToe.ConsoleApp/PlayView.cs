using TicTacToe.ConsoleApp;
using TicTacToe.Models;
using TicTacToe.Views;

internal class PlayView : WithGameView
{
    public PlayView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        bool isTicTacToe;
        do
        {
            isTicTacToe = _game.IsTicTacToe();
            if (!isTicTacToe)
            {
                new PlayerView(_game).Interact();
                _game.Next();
            }            
            new BoardView().Write(_game);
        } while (!isTicTacToe);
        new MessageView(MessageType.PLAYER_WIN).WriteLine(_game.CurrentPlayer.ToString());
    }
}