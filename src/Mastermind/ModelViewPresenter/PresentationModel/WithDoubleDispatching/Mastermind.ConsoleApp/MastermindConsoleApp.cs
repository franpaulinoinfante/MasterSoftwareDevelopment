using Mastermind.GameViews;

internal class MastermindConsoleApp : Mastermind.Mastermind
{
    protected override IGameVIew CreateGameView()
    {
        return new ConsoleView();
    }
}