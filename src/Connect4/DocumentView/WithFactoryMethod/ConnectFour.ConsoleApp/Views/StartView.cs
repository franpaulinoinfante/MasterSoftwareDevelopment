using ConnectFour.GameViews;
using ConnectFour.Models;

internal class StartView : WithGameView
{
    public StartView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        new MessageView().WriteLine(Message.Titile);
        new PlayerConfigurationView().SetPlayer(_game);
        _game.NewGame();
        new BoardView().Write(_game);
    }
}