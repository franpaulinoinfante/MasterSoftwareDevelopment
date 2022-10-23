using Mastermind.ConsoleApp;
using Mastermind.ConsoleApp.UseCasesViews.ViewModels;
using Mastermind.Models;

internal class ResumeView:WithGameView
{
    public ResumeView(Game game) : base(game)
    {
    }

    internal bool Interact()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(Message.Resume.ToString());
        if (yesNoDialog.IsAffirmative())
        {
            _game.NewGame();
        }
        return yesNoDialog.IsAffirmative();
    }
}