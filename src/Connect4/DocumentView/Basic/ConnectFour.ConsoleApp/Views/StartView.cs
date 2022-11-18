using ConnectFour.ConsoleApp.Views.ViewsModels;
using ConnectFour.ConsoleApp.Views.ViewsModels.PlayerViewModels;
using ConnectFour.Models;

namespace ConnectFour.ConsoleApp.Views;

internal class StartView
{
    private readonly Game _game;

    public StartView(Game game)
    {
        _game = game;
    }

    internal void Interact()
    {
        Message.Titile.WriteLine();
        new SetUpPlayerView().SetPlayers(_game);
        new BoardView().Write(_game);
    }
}