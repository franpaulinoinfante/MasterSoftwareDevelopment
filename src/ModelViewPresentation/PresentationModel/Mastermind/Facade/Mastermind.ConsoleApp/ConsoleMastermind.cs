using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp;

internal class ConsoleMastermind : Mastermind
{
    public ConsoleMastermind()
    {
        Play();
    }

    protected override GameView CreateGameView(Logic logic)
    {
        return new ConsoleView(logic);
    }
}
