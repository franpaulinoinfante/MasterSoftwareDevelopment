using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Models.Types;

namespace ConnectFourConsoleApp.Models;

internal class PlayerCreator
{
    internal static int MaxPlayers = 2;

    private static PlayerCreator? _instance;

    private PlayerCreator()
    {
    }

    internal static PlayerCreator Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new PlayerCreator();
            }
            return _instance;
        }
    }

    internal Player CreatePlayers(int position, Board board)
    {
        if (position < ReadNumberOfPlayer())
        {
            return new UserPlayer(board, Enum.GetValues<Token>()[position]);
        }
        else
        {
            return new MachinePlayer(board, Enum.GetValues<Token>()[position]);
        }
    }

    private int ReadNumberOfPlayer()
    {
        int players;
        bool valid = false;
        do
        {
            players = ConsoleIO.Instance.ReadInt(Message.Players.GetMessage());
            if (players >= 0 || players <= PlayerCreator.MaxPlayers)
            {
                valid = true;
            }
        } while (!valid);
        return players;
    }
}