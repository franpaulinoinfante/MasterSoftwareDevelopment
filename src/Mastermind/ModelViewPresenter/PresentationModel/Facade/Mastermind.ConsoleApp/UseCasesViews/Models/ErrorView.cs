using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCasesViews.Models;

internal class ErrorView : GameViews.ErrorView
{
    public override void WriteLine(ErrorCode errorCode)
    {
        if (!errorCode.IsNull())
        {
            if (errorCode == ErrorCode.WrongCharacters)
            {
                ConsoleIO.GetInstance().WriteLine($"{Errors[(int)errorCode]} {Enum.GetValues<ColorCode>().ToList().GetInitials()}");
            }
            else
            {
                ConsoleIO.GetInstance().WriteLine(Errors[(int)errorCode]);
            }
        }
    }
}
