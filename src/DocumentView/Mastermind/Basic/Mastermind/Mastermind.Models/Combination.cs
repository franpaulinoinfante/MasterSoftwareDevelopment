using Mastermind.Types;

namespace Mastermind.Models;

internal abstract class Combination
{
    protected Color[] _colors;
    protected internal const int Width = 4;

    public Combination()
    {
        _colors = new Color[Width];
    }
}
