using TicTacToe.ConsoleApp.ConsolesIOs;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;

internal class MessageView
{
    private readonly MessageType _messageType;

    private readonly string[] MESSAGES =
    {
        "--- TIC TAC TOE ---\n",
        "Number of user: ",
        "---------------",
        " | ",
        "Coordinate to put",
        "Enter a coordinate to put a token: ",
        "Origin coordinate to move: ",
        "Target coordinate to move",
        "#player player: You win!!! :-)",
        "Do you want to continue "
    };

    public MessageView(MessageType messageType)
    {
        _messageType = messageType;
    }

    internal void Write(MessageType messageType)
    {
        ConsoleIO.GetInstance().Write(MESSAGES[(int)messageType]);
    }

    internal void WriteLine()
    {
        ConsoleIO.GetInstance().WriteLine(MESSAGES[(int)_messageType]);
    }

    internal void WriteLine(MessageType messageType)
    {
        ConsoleIO.GetInstance().WriteLine(MESSAGES[(int)messageType]);
    }

    public override string ToString()
    {
        return MESSAGES[(int)_messageType];
    }
}