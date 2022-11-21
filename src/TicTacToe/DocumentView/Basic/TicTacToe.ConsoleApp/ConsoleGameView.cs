using TicTacToe.ConsoleApp.UseCaseView;
using TicTacToe.Models;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp;

internal class ConsoleGameView : GameView
{
    private readonly StartView _startView;
    private readonly SetUpPlayersView _setUpPlayersView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public ConsoleGameView(Game game) : base(game)
    {
        _startView = new StartView(game);
        _setUpPlayersView = new SetUpPlayersView(game);
        _playView = new PlayView(game);
        _resumeView = new ResumeView(game);
    }

    public override void Start()
    {
        _startView.Interact();
    }

    public override void SetUpPlayers()
    {
        _setUpPlayersView.Interact();
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