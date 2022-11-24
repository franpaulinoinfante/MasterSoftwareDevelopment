using ConnectFour.Types;

namespace ConnectFour.GameViews;

public abstract class ErrorView
{
    protected static string[] Errors =
    {
        "The colunm #colunm is complete",
        "The colunm is out ouf range, they must be: [1 - 7]",
        "The players are out of range, they must be: [0 - 2]",
    };

    protected Error _error;

    protected ErrorView(Error error)
    {
        _error = error;
    }

    public override string ToString()
    {
        return Errors[(int)_error];
    }

    public abstract void WriteLine();
}
