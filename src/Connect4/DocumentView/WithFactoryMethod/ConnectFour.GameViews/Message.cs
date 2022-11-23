using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.GameViews;

public enum Message
{
    Titile,
    HorizontalLine,
    VerticalLine,
    Turn,
    NumOfPlayers,
    Random,
    EnterColunmToDrop,
    InvalidColunm,
    CompleteColunm,
    PlayerWin,
    PlayersTied,
    Resume
}

public static class MessageExtension
{
    private static string[] Messages =
    {

    };


}
