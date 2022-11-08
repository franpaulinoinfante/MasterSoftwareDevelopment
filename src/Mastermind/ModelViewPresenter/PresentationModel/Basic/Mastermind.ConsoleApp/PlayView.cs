using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Controllers;
using Mastermind.GameViews;
using Mastermind.Types;

internal class PlayView
{
    private readonly PlayController _playController;

    public PlayView(PlayController playController)
    {
        _playController = playController;
    }

    internal void Interact()
    {
        do
        {
            List<ColorCode> colorCodes = new ProposedCombinationView().Read(_playController);
            _playController.AddProposedCombination(colorCodes);
            _playController.CheckResults();
            new BoardView().Write(_playController);
        } while (!_playController.IsFinished);

        MessageCode messageCode = MessageCode.Looser;
        if (_playController.IsWinner)
        {
            messageCode = MessageCode.Winner;
        }
        ConsoleIO.GetInstance().WriteLine(messageCode.GetMessage());
    }
}