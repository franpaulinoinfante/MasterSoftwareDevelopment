using Mastermind.Controllers;

namespace Mastermind.GameViews;

public abstract class WithGameView
{
    protected readonly Logic _logic;

    protected WithGameView(Logic logic)
    {
        _logic = logic;
    }
}
