using Mastermind.GameViews;

new MastermindConsoleApp().Start();

internal class MastermindConsoleApp : Mastermind.Mastermind
{
    protected override IGameVIew CreateGameView()
    {
        return new ConsoleView();
    }

    internal void Start()
    {
        Play();
    }
}