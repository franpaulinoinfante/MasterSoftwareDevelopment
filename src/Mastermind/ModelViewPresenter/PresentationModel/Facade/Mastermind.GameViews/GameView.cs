using Mastermind.Controllers;

namespace Mastermind.GameViews;

public abstract class GameView : WithGameView
{
    protected GameView(Logic logic) : base(logic)
    {
    }

    public abstract void Start();
    public abstract void Play();
    public abstract bool Resume();
}
