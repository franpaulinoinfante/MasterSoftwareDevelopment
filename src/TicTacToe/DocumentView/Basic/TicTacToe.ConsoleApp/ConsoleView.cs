using TicTacToe.ConsoleApp;
using TicTacToe.Models;
using TicTacToe.Views;

public class ConsoleView : View
{
    private readonly StartView _startView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public ConsoleView(Game game) : base(game)
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

    public override bool Resume()
    {
        return _resumeView.Interact();
    }


}