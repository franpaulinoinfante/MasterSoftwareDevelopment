using ConnectFour.ConsoleApp.Views.ViewsModels;
using ConnectFour.ConsoleApp.Views.ViewsModels.PlayerViewModels;
using ConnectFour.Models;

namespace ConnectFour.ConsoleApp.Views;

internal class PlayView
{
    private readonly Game _game;

    public PlayView(Game game)
    {
        _game = game;
    }

    internal void Interact()
    {
        do
        {
            PlayerView playerView = PlayerCreator.Instance.CreatePlayerView(_game);
            playerView.Interact();
            _game.Next();
        } while (!_game.IsFinished());

        if (_game.IsWinner())
        {
            Message.PlayerWin.WriteLine(_game.GetLastToken().ToString());
        }
        else
        {
            Message.PlayersTied.WriteLine();
        }
    }
}