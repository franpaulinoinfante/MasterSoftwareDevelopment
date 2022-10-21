using MastermindConsoleApp.ConsolesIOs;
using MastermindConsoleApp.Models.Types;
using System.Drawing;

namespace MastermindConsoleApp.Models;

internal class ProposedCombination : Combination
{
    private const int Duplicate = 2;
    private const int FisrtChar = 0;

    internal ColorType[] ColorTypes => _colorTypes;

    internal ProposedCombination Read()
    {
        string characters;
        ErrorType errorType;
        do
        {
            characters = ConsoleIO.GetInstance().ReadString(MessageType.ProposeCombination.GetToString());
            errorType = GetErrorTypeReadColor(characters);
            errorType.WriteLine(Enum.GetValues<ColorType>());
        } while (errorType != ErrorType.Null);
        AddPropose(characters);
        return this;
    }

    private ErrorType GetErrorTypeReadColor(string characters)
    {
        if (characters.Length != Combination.Width)
        {
            return ErrorType.WrongLength;
        }

        ColorType[] colorTypes = Enum.GetValues<ColorType>();
        for (int i = 0; i < characters.Length; i++)
        {
            ColorType color = GetColorType(characters[i]);
            if (color == Types.ColorType.Null)
            {
                return ErrorType.WrongCharacters;
            }
            if (IsDuplicate(color, characters))
            {
                return ErrorType.Duplicated;
            }
        }
        return ErrorType.Null;
    }

    private ColorType GetColorType(char character)
    {
        ColorType[] colorTypes = Enum.GetValues<ColorType>();
        int i = 0;
        while (i < colorTypes.Length && colorTypes[i].ToString().ToLower()[FisrtChar] != character)
        {
            i++;
        }
        if (i == colorTypes.Length)
        {
            --i;
        }
        return colorTypes[i];
    }

    private bool IsDuplicate(ColorType color, string characters)
    {
        int count = 0;
        for (int i = 0; i < characters.Length; i++)
        {
            if (color == GetColorType(characters[i]))
            {
                count++;
            }
        }
        return count == ProposedCombination.Duplicate;
    }

    private void AddPropose(string characters)
    {
        for (int i = 0; i < characters.Length; i++)
        {
            _colorTypes[i] = GetColorType(characters[i]);
        }
    }

    internal protected override void Write()
    {
        for (int i = 0; i < _colorTypes.Length; i++)
        {
            ConsoleIO.GetInstance().Write(_colorTypes[i].GetColorType().ToLower());
        }
    }
}