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
        new PlayerConfigurationView().Set(_game);
        new BoardView().Write(_game);
    }
}