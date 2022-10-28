using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind.ConsoleApp.UseCasesViews;

internal class ResumeView : WithGameView
{
    public ResumeView(Logic logic) : base(logic)
    {
    }

    internal bool Interact()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(MessageCode.Resume.GetMessage());
        return yesNoDialog.IsAffirmative();
    }
}