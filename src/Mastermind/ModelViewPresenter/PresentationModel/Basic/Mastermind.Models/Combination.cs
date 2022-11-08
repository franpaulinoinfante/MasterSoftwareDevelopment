using Mastermind.Types;

namespace Mastermind.Models;

internal class Combination
{
    protected List<ColorCode> _colorCodes;

    public Combination()
    {
        _colorCodes = new List<ColorCode>();
    }
}