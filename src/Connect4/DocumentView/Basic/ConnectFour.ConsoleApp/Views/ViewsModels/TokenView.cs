using ConnectFour.Types;

namespace ConnectFour.ConsoleApp.Views.ViewsModels;

internal class TokenView
{
    internal void Write(Token token)
    {
        
        if (!token.IsNull())
        {
            ConsoleIOs.ConsoleIO.Instance.Write($"{token} ");
        }
        else
        {
            ConsoleIOs.ConsoleIO.Instance.Write(" ");
        }
    }
}