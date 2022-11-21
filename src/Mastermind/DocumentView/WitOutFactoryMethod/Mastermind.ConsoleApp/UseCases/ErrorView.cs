using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCases;

internal class ErrorView : GameViews.ErrorView
{
    public override void WriteLine(ErrorCode errorCode)
    {
        if (!errorCode.IsNull())
        {
            ConsoleIO.GetInstance().WriteLine(Errors[(int)errorCode]);
        }
    }
}
