using Mastermind.ConsoleApp.UseCaseViews;
using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp;

internal class ConsoleView : IGameView
{
    private readonly StartView _startView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public ConsoleView(Game game)
    {
        _startView = new StartView(game);
        _playView = new PlayView(game);
        _resumeView = new ResumeView(game);
    }

    public void Start()
    {
        _startView.Interact();
    }

    public void Play()
    {
        _playView.Interact();
    }

    public bool Resume()
    {
        return _resumeView.Interact();
    }
}
