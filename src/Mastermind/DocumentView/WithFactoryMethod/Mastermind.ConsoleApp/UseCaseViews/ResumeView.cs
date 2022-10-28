using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;
using Mastermind.Models;

namespace Mastermind.ConsoleApp.UseCaseViews;

internal class ResumeView : WithGameView
{
    public ResumeView(Game game) : base(game)
    {
    }

    internal bool Interact()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(MessageCode.Resume.GetMessage());
        if (yesNoDialog.IsAffirmative())
        {
            _game.NewGame();
        }
        return yesNoDialog.IsAffirmative();
    }
}