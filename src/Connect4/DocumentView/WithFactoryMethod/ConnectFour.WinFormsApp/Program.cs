using ConnectFour.GameViews;
using ConnectFour.Models;

namespace ConnectFour.WinFormsApp;

internal class Program : ConnectFour
{
    private readonly Game _game;
    private static Dashboard _dashboard;

    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(_dashboard);
    }

    protected override GameView CreateGameView(Game game)
    {
        _dashboard = new Dashboard(_game);

    }
}