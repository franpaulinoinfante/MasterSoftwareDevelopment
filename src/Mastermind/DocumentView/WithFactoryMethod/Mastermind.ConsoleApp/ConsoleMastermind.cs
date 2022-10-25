using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp;

internal class ConsoleMastermind : Main
{
    public ConsoleMastermind()
    {
        Play();
    }


    protected override IGameView CreateGameView(Game game)
    {
        return new ConsoleView(game);
    }
}
