using ConnectFour.Models;
using ConnectFour.Utils;

namespace ConnectFour.ConsoleApp.Views.ViewsModels.PlayerViewModels;

internal class MachinePlayerView : PlayerView
{
    public MachinePlayerView(Game game) : base(game)
    {
    }

    protected override int GetColunm()
    {
        return new Random().Next(minValue: 0, Coordinate.Colunms);
    }
}
