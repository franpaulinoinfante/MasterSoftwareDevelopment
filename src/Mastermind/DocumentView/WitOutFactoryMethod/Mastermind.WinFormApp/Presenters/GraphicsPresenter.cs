using Mastermind.GameViews;
using Mastermind.Models;
using Mastermind.WinFormApp.Views;

namespace Mastermind.WinFormApp.Presenters;

internal class GraphicsPresenter : GameView
{
    private readonly IGraphic _graphic;
    private BindingSource _proposedCombinationSource;

    public GraphicsPresenter(IGraphic graphic, Game game) : base(game)
    {
        _graphic = graphic;
        _graphic.GetproposedCombinationEvent += GetProposedCombinations;
        _proposedCombinationSource = new BindingSource();
        _graphic.GetProposeCombinationsBindingSource(_proposedCombinationSource);
        GetProposedCombinations();
        Start();
        //_gameView.DisplaysBoard();
    }

    private void GetProposedCombinations()
    {
        for (int i = 0; i < _game.Attempts; i++)
        {
        }
    }

    private void GetProposedCombinations(object sender, EventArgs e)
    {

    }

    public override void Play()
    {
        throw new NotImplementedException();
    }

    public override bool Resume()
    {
        throw new NotImplementedException();
    }

    public override void Start()
    {
        _graphic.Title = GameViews.Message.Title.GetString();
        _graphic.SecrectCombination = GameViews.Message.SecrectCombination.GetString();
    }
}
