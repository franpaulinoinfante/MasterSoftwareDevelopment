using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models;

internal abstract class Combination
{
    protected ColorType[] _colorTypes;
	protected int _colors;
	
	protected const int Width = 4;

	public Combination()
	{
		_colorTypes = new ColorType[Width];
		_colors = 0;
	}

	internal protected abstract void Write();
}