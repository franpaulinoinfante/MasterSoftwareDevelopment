using MastermindConsoleApp.ConsoleIOs;
using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models;

internal class ProposedCombination : Combination
{
    private const int Duplicate = 2;
    private const int FisrtChar = 0;

    internal Types.Color[] ColorTypes => _colorTypes;

    internal ProposedCombination Read()
    {
        string characters;
        Error errorType;
        do
        {
            characters = ConsoleIO.GetInstance().ReadString(Message.ProposeCombination.GetToString());
            errorType = GetErrorTypeToReadColorType(characters);
            errorType.WriteLine(Enum.GetValues<Color>());
        } while (errorType != Error.Null);
        AddPropose(characters);
        return this;
    }

    private Error GetErrorTypeToReadColorType(string characters)
    {
        if (characters.Length != Combination.Width)
        {
            return Error.WrongLength;
        }

        Color[] colorTypes = Enum.GetValues<Color>();
        for (int i = 0; i < characters.Length; i++)
        {
            Types.Color color = GetColorType(characters[i]);
            if (color == Types.Color.Null)
            {
                return Error.WrongCharacters;
            }
            if (IsDuplicate(color, characters))
            {
                return Error.Duplicated;
            }
        }
        return Error.Null;
    }

    private Types.Color GetColorType(char character)
    {
        Color[] colorTypes = Enum.GetValues<Color>();
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

    private bool IsDuplicate(Types.Color color, string characters)
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

    protected internal override void Write()
    {
        for (int i = 0; i < _colorTypes.Length; i++)
        {
            ConsoleIO.GetInstance().Write(_colorTypes[i].GetColorType().ToLower());
        }
    }
}