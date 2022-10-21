﻿using MastermindConsoleApp.ConsolesIOs;
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
    private static string[] Errors =
    {
        "Repeated color",
        "Wrong colors, they must be: #replace",
        "Wrong proposed combination length",
        ""
    };

    internal static void WriteLine(this ErrorType errorType)
    {
        if (errorType != ErrorType.Null)
        {
            ConsoleIO.GetInstance().WriteLine(Errors[(int)errorType]);
        }
    }

    internal static void WriteLine(this ErrorType errorType, ColorType[] colorTypes)
    {
        string replace = string.Empty;
        for (int i = 0; i < colorTypes.Length; i++)
        {
            replace += colorTypes[i].GetColorType().ToLower();
        }
        ConsoleIO.GetInstance().WriteLine(Errors[(int)errorType].Replace("#replace", replace));
    }

    internal static string ToString(this ErrorType errorType)
    {
        return Errors[(int)errorType];
    }
}