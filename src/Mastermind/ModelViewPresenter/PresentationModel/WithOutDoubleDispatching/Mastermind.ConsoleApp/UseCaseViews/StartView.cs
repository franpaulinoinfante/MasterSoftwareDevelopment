using Mastermind.ConsoleApp.UseCaseViews.ViewModels;
using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp.UseCaseViews;

internal class StartView
{
    internal void Interact(StartController startController)
    {
        new MessageView().WriteLine(MessageCode.Title);
        startController.NewGame();
        new BoardView().Write(startController);
        startController.NextState();
    }
}
