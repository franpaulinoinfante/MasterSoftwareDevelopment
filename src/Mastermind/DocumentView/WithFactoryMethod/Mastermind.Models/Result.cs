namespace Mastermind.Models;

internal class Result
{
    private readonly int _blacks;
    private readonly int _whites;

    private const int WinnerResult = 4;

    public Result(int blacks, int whites)
    {
        _blacks = blacks;
        _whites = whites;
    }

    public int Blacks => _blacks;

    public int Whites => _whites;

    internal bool IsWinner()
    {
        return _blacks == WinnerResult;
    }
}