using Mastermind.Controllers;
using Mastermind.GameViews;

internal class ConsoleView : IGameVIew
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

    public void Visit(StartController startController)
    {
        _startView.Interact(startController);
    }

    public void Visit(PlayController playController)
    {
        _playView.Interact(playController);
    }

    public bool Visit(ResumeController resumeController)
    {
        return _resumeView.Interact(resumeController);
    }
}