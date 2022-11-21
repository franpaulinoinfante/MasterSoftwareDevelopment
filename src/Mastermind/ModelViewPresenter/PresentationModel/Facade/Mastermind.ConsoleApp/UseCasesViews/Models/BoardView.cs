using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Controllers;

namespace Mastermind.ConsoleApp.UseCasesViews.Models;

internal class BoardView
{
    public BoardView()
    {
    }

    internal void Write(Logic logic)
    {
        ConsoleIO.GetInstance().WriteLine();
        new MessageView(GameViews.MessageCode.SecrectCombination).WriteLine();
        int attempts = logic.GetAttempts();
        new MessageView(GameViews.MessageCode.Attempts).WriteLine(attempts);
        for (int i = 0; i < attempts; i++)
        {
            new ProposedCombinationView().Write(logic.GetPropusedCombination(i));
            new ResultView(logic).WriteLine(i);
        }
        //ConsoleIO.GetInstance().WriteLine();
    }
}