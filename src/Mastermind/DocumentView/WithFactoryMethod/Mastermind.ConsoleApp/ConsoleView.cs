using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp;

internal class ConsoleView : IGameView
{
    private StartView _startView;

    public ConsoleView(Game game)
    {
        _startView = new StartView(game);
    }

    public void Play()
    {
        _startView.Interact();
    }

    public bool Resume()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }
}
