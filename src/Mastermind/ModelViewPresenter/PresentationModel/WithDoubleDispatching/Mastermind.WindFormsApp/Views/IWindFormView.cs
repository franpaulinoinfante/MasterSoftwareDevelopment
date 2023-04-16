using Mastermind.GameViews;

namespace Mastermind.WindFormsApp.Views;

internal interface IWindFormView : IGameVIew
{
    string Title { get; set; }

    event EventHandler StartEvent;
}
