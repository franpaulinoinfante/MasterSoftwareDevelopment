using ConnectFourConsoleApp.Types;

namespace ConnectFourConsoleApp.Models.Players;

internal class PlayerCreator
{
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

    internal Player CreatePlayers(int position, int players, Board board)
    {
        if (position < players)
        {
            return new UserPlayer(board, Enum.GetValues<Token>()[position]);
        }
        else
        {
            return new MachinePlayer(board, Enum.GetValues<Token>()[position]);
        }
    }
}