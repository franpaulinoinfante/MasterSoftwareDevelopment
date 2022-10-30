using Mastermind.ConsoleApp;
using Mastermind.GameViews;

new ConsoleMastermind().Execute();

internal class ConsoleMastermind : Mastermind.Mastermind
{
    public override IGameView CreateGameView()
    {
        return new ConsoleView();
    }

    internal void Execute()
    {
        Play();
    }
}