using ConnectFour.Models;

namespace ConnectFour.ConsoleApp.Views;

internal class GameView
{
    private readonly Game _game;
    private readonly StartView _startView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public GameView(Game game)
    {
        _game = game;
        _startView = new StartView(_game);
        _playView = new PlayView(_game);
        _resumeView = new ResumeView(_game);
    }

    internal void Start()
    {
        _startView.Interact();
    }

    internal void Play()
    {
        _playView.Interact();
    }

    internal bool IsResume()
    {
        return _resumeView.Interact();
    }
}
