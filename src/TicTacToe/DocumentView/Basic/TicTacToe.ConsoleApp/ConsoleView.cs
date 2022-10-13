using TicTacToe.ConsoleApp;
using TicTacToe.Models;
using TicTacToe.Views;

internal class ConsoleView : View
{
    private readonly StartView _startView;
    private readonly GameView _playView;
    private readonly ResumeView _resumeView;

    public ConsoleView(Game game) : base(game)
    {
        _startView = new StartView(game);
        _playView = new GameView(game);
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

    public override bool Resume()
    {
        return _resumeView.Interact();
    }
}