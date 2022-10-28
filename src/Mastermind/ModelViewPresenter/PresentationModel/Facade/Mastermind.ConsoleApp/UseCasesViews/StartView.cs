using Mastermind.ConsoleApp.UseCasesViews.Models;
using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp.UseCasesViews
{
    internal class StartView : WithGameView
    {
        public StartView(Logic logic) : base(logic)
        {
        }

        internal void Interact()
        {
            new MessageView(MessageCode.Title).WriteLine();
            new BoardView().Write(_logic);
            _logic.NewGame();
        }
    }
}