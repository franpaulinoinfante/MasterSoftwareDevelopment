using Mastermind.ConsoleApp.UseCaseViews;
using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp;

internal class ConsoleView : IGameView
{
    private readonly StartView _startView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public ConsoleView()
    {
        _startView = new StartView();
        _playView = new PlayView();
        _resumeView = new ResumeView();
    }

    public void Start(StartController startController)
    {
        _startView.Interact(startController);
    }

    public void Play(PlayController playController)
    {
        _playView.Interact(playController);
    }

    public bool Resume(ResumeController resumeController)
    {
        return _resumeView.Interact(resumeController);
    }
}
