using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Types;

public enum Token
{
    X,
    O,
    Null
}

public static class TokenExtension
{
    public static bool IsNull(this Token token)
    {
        return token == Token.Null;
    }
}