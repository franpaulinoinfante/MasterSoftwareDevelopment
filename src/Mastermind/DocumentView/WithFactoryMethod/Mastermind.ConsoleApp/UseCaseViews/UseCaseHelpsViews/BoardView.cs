using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp.UseCaseViews.UseCaseHelpsViews;

internal class BoardView
{
    internal void Write(Game game)
    {
        ConsoleIO.GetInstance().WriteLine();
        MessageView messageView = new MessageView();
        messageView.WriteLine(MessageCode.SecrectCombination);
        int attempts = game.Attempts;
        messageView.WriteLine(MessageCode.Attempts, attempts);
        for (int i = 0; i < attempts; i++)
        {
            new ProposedCombinationView(game).Write(i);
            new ResultView().WriteLine(game, i);
        }
        ConsoleIO.GetInstance().WriteLine();
    }
}