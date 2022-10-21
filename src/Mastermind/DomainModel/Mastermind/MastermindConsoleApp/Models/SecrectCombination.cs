using MastermindConsoleApp.Models.Types;
using System.Drawing;

namespace MastermindConsoleApp.Models;

internal class SecrectCombination : Combination
{
    public SecrectCombination()
    {
        ColorType[] colorTypes = Enum.GetValues<ColorType>();
        Random random = new Random();
        int position = random.Next(minValue: 0, colorTypes.Length);
        _colorTypes[_colors] = colorTypes[position];
        _colors++;
        while (_colors < Combination.Width)
        {
            position = random.Next(minValue: 0, colorTypes.Length);
            if (!IsDuplicate(colorTypes[position]))
            {
                _colorTypes[_colors] = colorTypes[position];
                _colors++;
            }
        }
    }

    private bool IsDuplicate(ColorType colorType)
    {
        int count = 0;
        for (int i = 0; i < _colorTypes.Length; i++)
        {
            if (colorType == _colorTypes[i])
            {
                count++;
            }
        }
        return count == 2;
    }

    internal Result GetResult(ProposedCombination proposedCombination)
    {
        int whites = 0;
        int blacks = 0;
        for (int i = 0; i < proposedCombination.ColorTypes.Length; i++)
        {
            if (Constain(proposedCombination.ColorTypes[i]))
            {
                whites++;
            }
            if (Constain(proposedCombination.ColorTypes[i], i))
            {
                blacks++;
            }
        }
        return new Result(whites, blacks);
    }

    private bool Constain(ColorType colorType)
    {
        int i = 0;
        while (i < Combination.Width || colorType != _colorTypes[i])
        {
            i++;
        }
        return colorType == _colorTypes[i];
    }

    private bool Constain(ColorType colorType, int position)
    {
        for (int i = 0; i < _colorTypes.Length; i++)
        {
            if (Constain(colorType) && i == position)
            {
                return true;
            }
        }
        return false;
    }

    internal protected override void Write()
    {
        MessageType.SecretCombination.WriteLine();
    }
}