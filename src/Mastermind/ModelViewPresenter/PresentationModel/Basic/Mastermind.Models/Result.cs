namespace Mastermind.Models;

internal class Result
{
    private int _blacks;
    private int _whites;
    public static int Width = 4;

    public Result(int blakcs, int whites)
    {
        _blacks = blakcs;
        _whites = whites;
    }

    public int Blacks => _blacks;

    public int Whites => _whites;

    public bool IsWinner => Blacks == Width;
}