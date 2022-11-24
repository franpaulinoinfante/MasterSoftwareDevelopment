using ConnectFour.ConsoleApp.Views.ViewModels;
using ConnectFour.Models;
using ConnectFour.Types;

internal class PlayerViewCreator
{
    private static PlayerViewCreator? _instante;

    private PlayerViewCreator()
    {
        _instante = null;
    }

    public static PlayerViewCreator Instance
    {
        get
        {
            if (_instante == null)
            {
                _instante = new PlayerViewCreator();
            }
            return _instante;
        }
    }

    public PlayerView Create(Game game)
    {
        if (game.GetPlayerTypeFromTurn() == PlayerType.UserPlayer)
        {
            return new UserPlayerView(game);
        }
        else
        {
            return new MachinePlayerView(game);
        }
    }
}