using MastermindConsoleApp.ConsolesIOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindConsoleApp.Models.Types;

internal enum ErrorType
{   Duplicated,
    WrongCharacters,
    WrongLength,
    Null
}

internal static class ExtensionErrorType
{
    private static string[] _errors =
    {
        "Repeated color",
        "Wrong colors, they must be: #replace",
        "Wrong proposed combination length",
    };

    internal static void WriteLine(this ErrorType errorType)
    {
        if (errorType != ErrorType.Null)
        {
            ConsoleIO.GetInstance().WriteLine(_errors[(int)errorType]);
        }
    }
    internal static void WriteLine(this ErrorType errorType, string replace)
    {
        ConsoleIO.GetInstance().WriteLine(_errors[(int)errorType].Replace("#replace", replace));
    }

    internal static string ToString(this ErrorType errorType)
    {
        return _errors[(int)errorType];
    }
}
