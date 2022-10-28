using Mastermind.ConsoleApp.UseCasesViews.Models;
using Mastermind.Controllers;
using Mastermind.GameViews;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCasesViews;

internal class PlayView : WithGameView
{
    public PlayView(Logic logic) : base(logic)
    {
    }

    internal void Interact()
    {
        do
        {
            IEnumerable<ColorCode> colorCodes = new ProposedCombinationView().Read(_logic);
            _logic.AddProposedCombination(colorCodes);
            _logic.CheckResult();
            new BoardView().Write(_logic);
        } while (!_logic.IsFinished());
        new ResultView(_logic).WriteLine();
    }
}