using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models;

internal class Result
{
    private readonly int _whites;
    private readonly int _blacks;

    private const int Width = 4;

    public Result(int whites, int blacks)
    {
        _whites = whites;
        _blacks = blacks;
    }

    internal bool IsWinner()
    {
        return _blacks == Width;
    }

    internal void WriteLine()
    {
        Message.Results.WriteLine(_blacks, _whites - _blacks);
    }
}