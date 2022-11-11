﻿using ConnectFourConsoleApp.ConsoleIOs;

namespace ConnectFourConsoleApp.Types;

internal enum ErrorCode
{
    WrongColunm,
    ColunmIsComplete,
    Null
}

internal static class ErrorCodeExtension
{
    private static readonly string[] Errors =
    {
        "Wrong colunm",
        "The colunm is full"
    };

    internal static bool IsNull(this ErrorCode errorCode)
    {
        return errorCode == ErrorCode.Null;
    }

    internal static void WriteLine(this ErrorCode errorCode)
    {
        if (!errorCode.IsNull())
        {
            ConsoleIO.GetInstance().WriteLine(Errors[(int)errorCode]);
        }
    }
}