using Mastermind.Types;

namespace Mastermind.Models;

internal abstract class Combination
{
    protected ColorCode[] _colorCodes;
    protected int _index;

    internal static int Width = 4;

    public Combination()
    {
        _colorCodes = new ColorCode[Width];
        _index = 0;
    }

    public Combination(ColorCode[] colorCodes)
    {
        _colorCodes = colorCodes;
        _index = colorCodes.Length;
    }
}
