using ConnectFour.Models;
using ConnectFour.Types;

namespace ConnectFour.ConsoleApp.Views.ViewsModels.PlayerViewModels;

internal class PlayerCreator
{
    private static PlayerCreator? _instance;

    private PlayerCreator()
    {
        _instance = null;
    }

    public static PlayerCreator Instance
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

    internal PlayerView CreatePlayerView(Game game)
    {
        if (game.GetPlayerType() == PlayerType.UserPlayer)
        {
            return new UserPlayerView(game);
        }

        return new MachinePlayerView(game);
    }
}