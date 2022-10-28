using Mastermind.Controllers;
using Mastermind.GameViews;

internal class ConsoleGameView : GameView
{
    private readonly StartView _startView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public ConsoleGameView(StartController startController, PlayController playController, ResumeController resumeController) : base(startController, playController, resumeController)
    {
        _startView = new StartView(startController);
        _playView = new PlayView(playController);
        _resumeView = new ResumeView(resumeController);
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