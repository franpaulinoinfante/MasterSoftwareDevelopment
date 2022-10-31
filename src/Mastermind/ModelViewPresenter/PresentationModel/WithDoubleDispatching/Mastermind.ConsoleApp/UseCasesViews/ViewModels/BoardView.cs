using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.ConsoleApp.UseCasesViews.ViewModels;
using Mastermind.Controllers;
using Mastermind.GameViews;

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
            new ResultView().WriteLine(controller.GetBlacks(i), controller.GetWhites(i));
        }
        ConsoleIO.GetInstance().WriteLine();
    }
}