using ConnectFour.GameViews;
using ConnectFour.Models;
using ConnectFour.Types;

namespace ConnectFour.ConsoleApp.Views.ViewModels;

internal abstract class PlayerView : WithGameView
{
    public PlayerView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        int colunm;
        Error error;
        do
        {
            colunm = ReadColunm();
            error = GetErrorToDrop(colunm);
        } while (!error.IsNull());

        _game.Drop(colunm);
    }

    protected abstract int ReadColunm();

    protected virtual Error GetErrorToDrop(int colunm)
    {
        return _game.GetErrorToDrop(colunm);
    }
}
