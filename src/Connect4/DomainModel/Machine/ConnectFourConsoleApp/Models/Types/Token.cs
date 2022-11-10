using ConnectFourConsoleApp.ConsoleIOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourConsoleApp.Models.Types;
internal enum Token
{
    X,
    O,
    Null
}

internal static class TokenExtension
{
    internal static void Write(this Token token)
    {
        if (token.IsNull())
        {
            ConsoleIO.Instance.Write(" ");
        }
        else
        {
            ConsoleIO.Instance.Write(token.ToString());
        }
    }

    internal static bool IsNull(this Token token)
    {
        return token == Token.Null;
    }
}
