using Mastermind.ConsoleApp;
using Mastermind.ConsoleApp.UseCasesViews.Views;
using Mastermind.Models;
using Mastermind.Types;

internal class PlayView : WithGameView
{
    public PlayView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        do
        {
            Color[] colors = new ProposedCombinationView().Read(_game);
            _game.Add(colors);
            _game.CheckResult();
            new BoardView().Write(_game);
        } while (!_game.IsFinished());
        Message message = Message.Lost;
        if (_game.isWinner())
        {
            message = Message.Winner;
        }
        message.WriteLine();
    }
}