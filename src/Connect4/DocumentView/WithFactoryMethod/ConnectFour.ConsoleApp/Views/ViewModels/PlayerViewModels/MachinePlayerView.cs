using ConnectFour.ConsoleApp.Views.ViewModels;
using ConnectFour.Models;
using ConnectFour.Utils;

internal class MachinePlayerView : PlayerView
{
    public MachinePlayerView(Game game) : base(game)
    {

    }

    protected override int ReadColunm()
    {
        Task.Delay(600).Wait();
        return new Random().Next(minValue: 0, Coordinate.MaxColumns);
    }
}