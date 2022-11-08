using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.UseCaseView.PlayerViews;

internal class PlayerViewProtoype
{
    private readonly Dictionary<PlayerType, PlayerView> _playersViewAsoc;

    public PlayerViewProtoype()
    {
        _playersViewAsoc = new Dictionary<PlayerType, PlayerView>
        {
            { PlayerType.USER, new UserPlayerView() },
            { PlayerType.MACHINE, new MachinePlayer() }
        };
    }

    internal PlayerView CreateView(PlayerType playerType)
    {
        return _playersViewAsoc[playerType];
    }
}
