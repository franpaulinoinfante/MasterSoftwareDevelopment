using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp;

internal class ConsoleMastermind : Main
{
    public ConsoleMastermind()
    {
        Execute();
    }

    private void Execute()
    {
        Play();
    }

    protected override IGameView CreateGameView(Game game)
    {
        return new ConsoleView(game);
    }
}
