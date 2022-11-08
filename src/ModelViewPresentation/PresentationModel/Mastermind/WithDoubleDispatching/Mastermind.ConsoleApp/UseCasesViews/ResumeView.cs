using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Controllers;
using Mastermind.GameViews;

internal class ResumeView
{
    internal bool Interact(ResumeController resumeController)
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(MessageCode.Resume.GetMessage());
        if (yesNoDialog.IsAffirmative())
        {
            resumeController.NewGame();
        }
        resumeController.NextState();
        return yesNoDialog.IsAffirmative();
    }
}