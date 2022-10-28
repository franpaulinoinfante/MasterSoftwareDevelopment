using Mastermind.GameViews;
using Mastermind.Models;
using Mastermind.WinFormApp.Presenters;

namespace Mastermind.WinFormApp.Views;

internal class GraphicMastermind
{
    private readonly Game _game;
    private readonly GameView _gameView;
    private readonly IGraphic _iGameView;

    public GraphicMastermind()
    {
        _game = new Game();
        _iGameView = new WinFormView();
        _gameView = new GraphicsPresenter(_iGameView, _game);
    }

    internal Form Execute()
    {
        return (Form)_iGameView;
    }
}
