using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Controllers;
using Mastermind.GameViews;

internal class ResumeView
{
    private readonly ResumeController _resumeController;

    public ResumeView(ResumeController resumeController)
    {
        _resumeController = resumeController;
    }

    internal bool Interact()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(MessageCode.Resume.GetMessage());
        if (yesNoDialog.IsAffirmative())
        {
            _resumeController.NewGame();
        }
        return yesNoDialog.IsAffirmative();
    }
}