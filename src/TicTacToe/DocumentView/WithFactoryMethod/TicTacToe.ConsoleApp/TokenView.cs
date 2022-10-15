using TicTacToe.Types;

namespace TicTacToe.ConsoleApp
{
    internal class TokenView
    {
        internal void Write(Token token)
        {
            string color = Enum.GetName(token);
            if (token == Token.NULL)
            {
                color = " ";
            }
            ConsoleIO.GetInstance().Write(color);
        }
    }
}