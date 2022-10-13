using TicTacToe.Views;

namespace TicTacToe.ConsoleApp
{
    internal class MessageView
    {
        private readonly string[] MESSAGES = new string[]
        {
            "--- TIC TAC TOE ---",
            "---------------",
            " | ",
            "Enter a coordinate to put a token: ",
            "Coordinate to put",
            "Origin coordinate to move: ",
            "Target coordinate to move",
            "#player player: You win!!! :-)",
            "Do you want to continue "
        };

        public MessageView()
        {
        }

        public MessageView(MessageType rESUME)
        {
        }

        internal void WriteLine(MessageType type)
        {

        }
    }
}