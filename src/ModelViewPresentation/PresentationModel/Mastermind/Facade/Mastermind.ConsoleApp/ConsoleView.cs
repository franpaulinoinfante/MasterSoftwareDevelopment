using Mastermind.ConsoleApp.UseCasesViews;
using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp;

internal class ConsoleView : GameView
{
    private readonly StartView _startView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public ConsoleView(Logic logic) : base(logic)
    {
        _startView = new StartView(logic);
        _playView = new PlayView(logic);
        _resumeView = new ResumeView(logic);
    }

    public override void Start()
    {
        _startView.Interact();
    }

    public override void Play()
    {
        _playView.Interact();
    }

    public override bool Resume()
    {
        return _resumeView.Interact();
    }
}
