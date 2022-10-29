using Mastermind.ConsoleApp;
using Mastermind.GameViews;

new ConsoleMastermind();

internal class ConsoleMastermind : Mastermind.Mastermind
{
    public ConsoleMastermind()
    {
        Play();
    }

    protected override IGameView CreateGameView()
    {
        return new ConsoleView();
    }
}