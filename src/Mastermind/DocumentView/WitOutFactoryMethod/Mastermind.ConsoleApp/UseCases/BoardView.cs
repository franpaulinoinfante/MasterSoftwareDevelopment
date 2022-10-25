using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp.UseCases;

internal class BoardView
{
    internal void Write(Game game)
    {
        ConsoleIO.GetInstance().WriteLine();
        int attempts = game.Attempts;
        new MessageView().WriteLine(Message.SecrectCombination);
        new MessageView().WriteLine(Message.Attempts, attempts);
        for (int i = 0; i < attempts; i++)
        {
            new ProposedCombinationView().Write(game.GetProposedCombination(i));
            new MessageView().WriteLine(Message.Result, game.GetBlacks(i), game.GetWhites(i));
        }
        ConsoleIO.GetInstance().WriteLine();
    }
}