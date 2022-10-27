using Mastermind.Controllers;
using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind;

public abstract class Mastermind
{
    private readonly Game _game;
    private readonly GameView _gameView;
    protected StartController _startController;
    protected PlayController _playController;
    protected ResumeController _resumeController;

    public Mastermind()
    {
        _game = new Game();
        _startController = new StartController(_game);
        _playController = new PlayController(_game);
        _resumeController = new ResumeController(_game);
        _gameView = CreateGameView();
    }

    protected abstract GameView CreateGameView();

    public void Play()
    {
        do
        {
            _gameView?.Start();
            _gameView.Play();
        } while (_gameView.Resume());
    }
}
