using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.ConsoleApp.UseCasesViews.Views;
using Mastermind.Types;

internal class ErrorView
{

    private static string[] Messages =
    {
        "Repeated colors",
       $"Wrong colors, they must be:  {new ColorView().GetAllInitials()}",
        "Wrong proposed combination length"
    };

    internal void WriteLine(Error error)
    {
        if (!error.IsNull())
        {
            ConsoleIO.GetInstance().WriteLine(Messages[(int)error]);
        }
    }
}