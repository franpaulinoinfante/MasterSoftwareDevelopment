using Mastermind.GameViews;

internal class ConsoleMastermind : Mastermind.Mastermind
{
    public ConsoleMastermind()
    {
        Play();
    }

    protected override GameView CreateGameView()
    {
        return new ConsoleGameView(_startController, _playController, _resumeController);
    }
}