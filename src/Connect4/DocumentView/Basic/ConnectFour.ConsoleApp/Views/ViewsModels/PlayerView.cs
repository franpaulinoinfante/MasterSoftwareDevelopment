using ConnectFour.Models;
using ConnectFour.Types;

namespace ConnectFour.ConsoleApp.Views.ViewsModels;

internal abstract class PlayerView
{
    private readonly Game _game;

    protected PlayerView(Game game)
    {
        _game = game;
    }

    internal void Interact()
    {
        int colunm;
        Error error;
        do
        {
            colunm = GetColunm();
            error = GetErrorToDrop(colunm);
        } while (!error.IsNull());

        _game.Drop(colunm);
    }

    protected abstract int GetColunm();

    protected virtual Error GetErrorToDrop(int colunm)
    {
        return _game.GetErrorToDrop(colunm);
    }
}