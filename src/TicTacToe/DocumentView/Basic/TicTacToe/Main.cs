using TicTacToe.Models;
using TicTacToe.Views;

namespace TicTacToe;

public abstract class Main
{
    private Game _game;
    private View _view;

    public Main()
    {
        _game = new Game();
        _view = CreateView(_game);
    }

    protected abstract View CreateView(Game game);



    protected void Play()
    {
        Console.WriteLine("Hello World");
    }
}
