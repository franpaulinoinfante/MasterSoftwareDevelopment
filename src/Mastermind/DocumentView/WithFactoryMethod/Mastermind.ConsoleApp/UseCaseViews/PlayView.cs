using Mastermind.ConsoleApp.UseCaseViews.UseCaseHelpsViews;
using Mastermind.GameViews;
using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCaseViews
{
    internal class PlayView : WithGameView
    {
        public PlayView(Game game) : base(game)
        {
        }

        internal void Interact()
        {
            do
            {
                List<ColorCode> colorCodes = new ProposedCombinationView(_game).Read();
                _game.AddProposeCombination(colorCodes);
                _game.CheckResult();
                new BoardView().Write(_game);
            } while (!_game.IsFinished());
            if (_game.IsWinner())
            {
                new MessageView().WriteLine(MessageCode.Winner);
            }
            else
            {
                new MessageView().WriteLine(MessageCode.Looser);
            }
        }
    }
}