using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models;

internal abstract class Combination
{
    protected ColorType[] _colorTypes;
 
	protected const int Width = 4;

    public Combination()
	{
		_colorTypes = new ColorType[Width];
	}

	internal protected abstract void Write();
}