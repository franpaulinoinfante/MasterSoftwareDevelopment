using TicTacToe.Views;

namespace TicTacToe.ConsoleApp;

internal class MessageView
{
    private readonly MessageType _messageType;

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

    public MessageView(MessageType messageType)
    {
        _messageType = messageType;
    }

    internal void WriteLine(MessageType messageType)
    {
        ConsoleIO.GetInstance().WriteLine(MESSAGES[(int)messageType]);
    }

    internal void WriteLine(string title)
    {
        ConsoleIO.GetInstance().WriteLine(MESSAGES[(int)_messageType].Replace("#player", title));
    }

    internal void Write(MessageType messageType)
    {
        ConsoleIO.GetInstance().Write(MESSAGES[(int)messageType]);
    }

    public override string ToString()
    {
        return MESSAGES[(int)_messageType];
    }
}