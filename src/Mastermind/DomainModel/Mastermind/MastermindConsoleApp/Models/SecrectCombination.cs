using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models;

internal class SecrectCombination : Combination
{
    internal void GenerateSecrectCombination()
    {
        Types.Color[] colorTypes = Enum.GetValues<Types.Color>();
        Random random = new Random();
        int position = random.Next(minValue: 0, colorTypes.Length - 1);
        int colors = 0; ;
        _colorTypes[colors] = colorTypes[position];
        colors++;
        while (colors < Combination.Width)
        {
            position = random.Next(minValue: 0, colorTypes.Length - 1);
            if (!Constain(colorTypes[position]))
            {
                _colorTypes[colors] = colorTypes[position];
                colors++;
            }
        }
    }

    internal Result CheckResults(ProposedCombination proposedCombination)
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

    private bool Constain(Types.Color colorType)
    {
        int i = 0;
        while (i < Combination.Width && _colorTypes[i] != colorType)
        {
            i++;
        }
        if (i == Combination.Width)
        {
            return false;
        }
        return colorType == _colorTypes[i];
    }

    private bool Constain(Types.Color colorType, int position)
    {
        return _colorTypes[position] == colorType;
    }

    protected internal override void Write()
    {
        Message.SecretCombination.WriteLine();
    }
}