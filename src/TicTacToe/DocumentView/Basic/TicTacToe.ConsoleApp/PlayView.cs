using TicTacToe.ConsoleApp;
using TicTacToe.Models;
using TicTacToe.Views;

internal class PlayView : WithViewGame
{
    public PlayView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        bool isTicTacToe;
        do
        {
            new PlayerView(_game).Interact();
            isTicTacToe = _game.IsTicTacToe();
            if (!isTicTacToe)
            {
                _game.Next();
            }
            new BoardView().Write(_game);
        } while (!isTicTacToe);
        new MessageView(MessageType.PLAYER_WIN).WriteLine(Enum.GetName(_game.GetCurrentPlayer()));
    }
}