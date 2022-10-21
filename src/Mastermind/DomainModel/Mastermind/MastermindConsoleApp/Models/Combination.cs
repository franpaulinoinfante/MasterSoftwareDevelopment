using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models;

internal abstract class Combination
{
    protected const int Width = 4;

    protected ColorType[] _colorTypes;

	public Combination()
	{
		_colorTypes = new ColorType[Width];
	}

	internal protected abstract void Write();
}