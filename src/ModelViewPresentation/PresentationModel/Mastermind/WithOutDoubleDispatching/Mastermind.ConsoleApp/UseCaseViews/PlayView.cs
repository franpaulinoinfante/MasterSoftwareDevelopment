using Mastermind.ConsoleApp.UseCaseViews.ViewModels;
using Mastermind.Controllers;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCaseViews;

internal class PlayView
{
    internal void Interact(PlayController playController)
    {
        do
        {
            IEnumerable<ColorCode> colorCodes = new ProposedCombinationView().Read(playController);
            playController.AddProposedCombination(colorCodes);
            playController.CheckResult();
            new BoardView().Write(playController);
        } while (!playController.IsFinished());
        new ResultView().WriteLine(playController.IsWinner());
        playController.NextState();
    }
}
