using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Types;

internal class ErrorView
{

    private static readonly string[] Messages =
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

//GetInitial(colors[i]);