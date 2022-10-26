using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Types;

public enum ErrorCode
{
    Duplicated,
    WrongCharacters,
    WrongLength,
    Null
}

public static class ErrorCodeExtension
{
    public static bool IsNull(this ErrorCode errorCode)
    {
        return errorCode == ErrorCode.Null;
    }
}
