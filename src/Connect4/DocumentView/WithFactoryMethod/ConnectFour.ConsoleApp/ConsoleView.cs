using ConnectFour.GameViews;
using ConnectFour.Models;

internal class ConsoleView : GameView
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

    public override void Start()
    {
        _startView.Interact();
    }

    public override void Play()
    {
        _playView.Interact();
    }

    public override bool IsResume()
    {
        return _resumeView.Interact();
    }
}