using ConnectFourConsoleApp.Types;

namespace ConnectFourConsoleApp.Models.Players;

internal class PlayerCreator
{
    private static PlayerCreator? _instance;

    private PlayerCreator()
    {
        // for singleton
    }

    internal static PlayerCreator Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PlayerCreator();
            }
            return _instance;
        }
    }

    internal Player Create(int position, int players, Board board)
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