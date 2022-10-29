using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp.UseCaseViews.ViewModels;

internal class BoardView
{
    internal void Write(Controller controller)
    {
        ConsoleIO.GetInstance().WriteLine();
        new MessageView().WriteLine(MessageCode.SecrectCombination);
        int attempts = controller.GetAttempts();
        new MessageView().WriteLine(MessageCode.Attempts, attempts);
        for (int i = 0; i < attempts; i++)
        {
            new ProposedCombinationView().Write(controller.GetProposedCombination(i));
            new ResultView().WriteLine(MessageCode.Results, controller.GetBlacks(i), controller.GetWhites(i));
        }
        ConsoleIO.GetInstance().WriteLine();
    }
}
