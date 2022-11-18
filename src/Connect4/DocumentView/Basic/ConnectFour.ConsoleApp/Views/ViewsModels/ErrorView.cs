using ConnectFour.ConsoleApp.ConsoleIOs;
using ConnectFour.Types;

namespace ConnectFour.ConsoleApp.Views.ViewsModels;

internal class ErrorView
{
    private readonly string[] Errors = new string[]
    {
        "The entered value is out of range, [0,2]",
        "The colunm is out of range",
        "The colunm is complete"
    };

    internal void WriteLine(Error error)
    {
        if (!error.IsNull())
        {
            ConsoleIO.Instance.WriteLine(Errors[(int)error]);
        }
    }
}