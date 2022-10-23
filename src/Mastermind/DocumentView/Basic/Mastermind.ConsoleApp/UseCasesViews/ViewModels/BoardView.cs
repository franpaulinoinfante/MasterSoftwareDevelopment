using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.ConsoleApp.UseCasesViews.ViewModels;
using Mastermind.Models;

internal class BoardView
{
    internal void Write(Game game)
    {
        ConsoleIO.GetInstance().WriteLine();
        Message.Attempts.WriteLine(game.Attemps);
        Message.SecrectCombination.WriteLine();
        for (int i = 0; i < game.Attemps; i++)
        {
            new ProposedCombinationView().Write(game.GetProposedCombination(i));
            Message.Results.WriteLine(game.GetBlacks(i), game.GetWhites(i));
        }
    }
}