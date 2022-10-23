using Mastermind.ConsoleApp;
using Mastermind.ConsoleApp.UseCasesViews.Views;
using Mastermind.Models;

internal class StartView : WithGameView
{
    public StartView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        Message.Title.WriteLine();
        new BoardView().Write(_game);
    }
}