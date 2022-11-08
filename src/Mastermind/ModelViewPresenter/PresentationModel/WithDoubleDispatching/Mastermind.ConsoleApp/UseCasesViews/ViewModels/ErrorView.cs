using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCasesViews.ViewModels;

internal class ErrorView : GameViews.ErrorView
{
    public override void WriteLine(ErrorCode errorCode)
    {
        if (!errorCode.IsNull())
        {
            ConsoleIOs.ConsoleIO.GetInstance().WriteLine(Errors[(int)errorCode]);
        }
    }
}
