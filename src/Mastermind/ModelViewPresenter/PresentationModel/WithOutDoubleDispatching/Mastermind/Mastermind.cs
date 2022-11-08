using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind;

public abstract class Mastermind
{
    protected readonly Logic _logic;
    protected readonly IGameView _gameView;

    public Mastermind()
    {
        _logic = new Logic();
        _gameView = CreateGameView();
    }

    public abstract IGameView CreateGameView();

    protected void Play()
    {
        do
        {
            if (_logic.Controller is StartController)
            {
                _gameView.Start((StartController)_logic.Controller);
            }
            else
            {
                if (_logic.Controller is PlayController)
                {
                    _gameView.Play((PlayController)_logic.Controller);
                }
                else
                {
                    _gameView.Resume((ResumeController)_logic.Controller);
                }
            }
        } while (_logic.Controller != null);
    }

}
