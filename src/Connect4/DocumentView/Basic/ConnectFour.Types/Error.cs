using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Types;

public enum Error
{
    NumOfPlayerOutOfRange,
    ColunmIsOutOfRange,
    ColunmIsComplete,
    Null
}


public static class ErrorExtension
{
    public static bool IsNull(this Error error)
    {
        return error == Error.Null;
    }
}