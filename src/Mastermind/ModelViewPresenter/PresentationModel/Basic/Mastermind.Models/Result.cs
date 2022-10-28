namespace Mastermind.Models;

internal class Result
{
    private readonly int _blacks;
    private readonly int _whites;
    public static int Width = 4;

    public Result(int blakcs, int whites)
    {
        _blacks = blakcs;
        _whites = whites;
    }

    public int Blacks => _blacks;

    public int Whites => _whites;

    public bool IsWinner => Blacks == Result.Width;
}