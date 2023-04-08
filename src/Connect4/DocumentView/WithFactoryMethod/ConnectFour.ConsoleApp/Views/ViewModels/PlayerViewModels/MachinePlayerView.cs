using ConnectFour.ConsoleApp.Views.ViewModels;
using ConnectFour.GameViews;
using ConnectFour.Models;
using ConnectFour.Utils;

internal class MachinePlayerView : PlayerView
{
    public MachinePlayerView(Game game) : base(game)
    {

    }

    protected override int ReadColunm()
    {
        Task.Delay(800).Wait();

        int colunm = new Random().Next(minValue: 1, maxValue: 8);
        new MessageView().WriteLine(Message.RandomlyColunmToDrop, colunm);
        return colunm - 1;
    }
}