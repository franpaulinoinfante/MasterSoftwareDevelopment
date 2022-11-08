using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind;

public abstract class Mastermind
{
    private readonly Logic _logic;
    private readonly GameView _gameView;

    public Mastermind()
    {
        _logic = new Logic(new Models.Game());
        _gameView = CreateGameView(_logic);
    }

    protected abstract GameView CreateGameView(Logic logic);

    protected void Play()
    {
        do
        {
            _gameView.Start();
            _gameView.Play();
        } while (_gameView.Resume());
    }
}
