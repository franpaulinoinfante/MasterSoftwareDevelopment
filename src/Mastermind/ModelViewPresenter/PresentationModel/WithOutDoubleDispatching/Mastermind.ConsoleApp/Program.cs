using Mastermind.ConsoleApp;
using Mastermind.GameViews;

new ConsoleMastermind().Execute();

internal class ConsoleMastermind : Mastermind.Mastermind
{
    protected override IGameView CreateGameView()
    {
        return new ConsoleView();
    }

    internal void Execute()
    {
        Play();
    }
}