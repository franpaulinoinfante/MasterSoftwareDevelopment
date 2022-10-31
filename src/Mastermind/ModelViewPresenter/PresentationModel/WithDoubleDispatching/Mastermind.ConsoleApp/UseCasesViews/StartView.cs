using Mastermind.ConsoleApp.UseCasesViews.ViewModels;
using Mastermind.Controllers;
using Mastermind.GameViews;

internal class StartView
{
    internal void Interact(StartController startController)
    {
        new MessageView().WriteLine(MessageCode.Title);
        new BoardView().Write(startController);
        startController.NextState();
    }
}