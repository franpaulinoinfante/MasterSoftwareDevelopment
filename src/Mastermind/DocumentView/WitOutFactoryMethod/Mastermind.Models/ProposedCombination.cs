using Mastermind.Types;

namespace Mastermind.Models;

internal class ProposedCombination : Combination
{
    public ProposedCombination(ColorCode[] colorCodes) : base(colorCodes)
    {
    }

    public ColorCode[] ColorCodes => _colorCodes;

    internal ErrorCode GetErrorCodeToProposedCombination()
    {
        if (_index > Combination.Width)
        {
            return ErrorCode.WrongLength;
        }

        ColorCode[] correctColor = GetColorCodesNull();
        for (int i = 0; i < _index; i++)
        {
            ColorCode colorCode = _colorCodes[i];
            if (colorCode.IsNull())
            {
                return ErrorCode.WrongCharacters;
            }
            for (int j = 0; j < i; j++)
            {
                if (correctColor[j] == colorCode)
                {
                    return ErrorCode.Duplicated;
                }
            }
            correctColor[i] = colorCode;
        }
        return ErrorCode.Null;
    }

    private ColorCode[] GetColorCodesNull()
    {
        ColorCode[] colorCodes = new ColorCode[Combination.Width];
        for (int i = 0; i < Combination.Width; i++)
        {
            colorCodes[i] = ColorCode.Null;
        }
        return colorCodes;
    }
}