using Mastermind.GameViews;
using Mastermind.WindFormsApp.Views;

namespace Mastermind.WindFormsApp.Presenters;

internal class WindFormViewPresenter : Mastermind
{
    private IWindFormView _windFormView;

    public WindFormViewPresenter(IWindFormView windFormView)
    {
        _windFormView = windFormView;
    }

    protected override IGameVIew CreateGameView()
    {
        return _windFormView;
    }
}
