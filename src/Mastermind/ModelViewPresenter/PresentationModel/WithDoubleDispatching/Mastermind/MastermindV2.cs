using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind;

public class MastermindV2
{
    private readonly Logic _logic;
    private readonly IGameVIew _gameView;

    public MastermindV2(IGameVIew gameVIew)
    {
        _logic = new Logic();
        _gameView = gameVIew;
    }

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
