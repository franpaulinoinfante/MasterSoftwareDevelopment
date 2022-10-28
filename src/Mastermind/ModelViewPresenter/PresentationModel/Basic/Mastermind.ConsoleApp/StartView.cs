using Mastermind.Controllers;
using Mastermind.GameViews;

internal class StartView
{
    private readonly StartController _startController;

    public StartView(StartController startController)
    {
        _startController = startController;
    }

    internal void Interact()
    {
        new MessageView().WriteLine(MessageCode.Title);
        new BoardView().Write(_startController);
    }
}