using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCaseViews.UseCaseHelpsViews;

internal class ErrorView : GameViews.ErrorView
{
    public override void WriteLine(ErrorCode errorCode)
    {
        if (!errorCode.IsNull())
        {
            if (errorCode == ErrorCode.WrongCharacters)
            {
                ConsoleIO.GetInstance().WriteLine($"{Errors[(int)errorCode]} {GetInitials()}");
            }
            else
            {
                ConsoleIO.GetInstance().WriteLine(Errors[(int)errorCode]);
            }
        }
    }

    private string GetInitials()
    {
        return new ColorCodeView().GetInititals();
    }
}