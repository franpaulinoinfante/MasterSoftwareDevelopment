using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models;

internal abstract class Combination
{
    protected Color[] _colorTypes;

    protected const int Width = 4;

    public Combination()
    {
        _colorTypes = new Color[Width];
    }

    protected internal abstract void Write();
}