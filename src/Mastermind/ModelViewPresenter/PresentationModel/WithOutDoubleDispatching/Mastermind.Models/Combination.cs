using Mastermind.Types;

namespace Mastermind.Models;

internal abstract class Combination
{
    protected IEnumerable<ColorCode> _colorCodes;

    public Combination()
    {
        _colorCodes = new List<ColorCode>();
    }

    protected Combination(IEnumerable<ColorCode> colorCodes)
    {
        _colorCodes = colorCodes;
    }
}
