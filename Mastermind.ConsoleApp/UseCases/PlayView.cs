using Mastermind.GameViews;
using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCases;

internal class PlayView : WithGameView
{
    public PlayView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        do
        {
            ColorCode[] colorCodes = new ProposedCombinationView().Read(_game);
            _game.AddProposedCombination(colorCodes);
            _game.CheckResult();
            new BoardView().Write(_game);
        } while (!_game.IsFinished());

        Message message = Message.Looser;
        if (_game.IsWinner())
        {
            message = Message.Winner;
        }
        new MessageView().WriteLine(message);
    }
}