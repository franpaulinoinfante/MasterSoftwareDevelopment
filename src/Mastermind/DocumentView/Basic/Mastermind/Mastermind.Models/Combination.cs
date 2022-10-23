using Mastermind.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Models;

internal class Combination
{
    protected Color[] _colors;
	internal protected const int Width = 4;

	public Combination()
	{
		_colors = new Color[Width];
	}
}
