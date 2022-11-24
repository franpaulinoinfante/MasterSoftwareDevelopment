using ConnectFour.GameViews;
using ConnectFour.Models;

new Connect4().Init();

internal class Connect4 : ConnectFour.ConnectFour
{
    protected override GameView CreateGameView(Game game)
    {
        return new ConsoleView(game);
    }

    internal void Init()
    {
        Play();
    }
}