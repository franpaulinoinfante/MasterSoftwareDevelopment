using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind;

public abstract class Mastermind
{
    private readonly Logic _logic;
    private readonly IGameVIew _gameView;

    public Mastermind()
    {
        _logic = new Logic();
        _gameView = CreateGameView();
    }

    protected abstract IGameVIew CreateGameView();

    public void Play()
    {
        Controller controller;
        do
        {
            controller = _logic.Controller;
            controller?.Accept(_gameView);
        } while (controller != null);
    }
}
