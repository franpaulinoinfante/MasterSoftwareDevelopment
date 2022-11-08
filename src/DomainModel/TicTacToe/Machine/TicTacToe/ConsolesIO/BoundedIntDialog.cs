using System.Diagnostics;
using TicTacToe.Types;

namespace TicTacToe.ConsolesIO;

internal class BoundedIntDialog
{
    private readonly ClosedInterval _limit;

    public BoundedIntDialog(int min, int max)
    {
        _limit = new ClosedInterval(min, max);
    }

    public int Read(string message)
    {
        Debug.Assert(message != null);

        bool error;
        int value;
        do
        {
            value = ConsoleIO.GetInstance().ReadInt($"{message} ? {_limit.ToString()}: ");
            error = _limit.IsIncluide(value);
        } while (!error);
        return value;
    }
}
