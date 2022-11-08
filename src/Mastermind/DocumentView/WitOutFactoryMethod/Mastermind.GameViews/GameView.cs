using Mastermind.Models;

namespace Mastermind.GameViews;

public abstract class GameView : WithGameView
{
    public GameView(Game game) : base(game)
    {
    }

    public abstract void Start();

    public abstract void Play();

    public abstract bool Resume();
}
