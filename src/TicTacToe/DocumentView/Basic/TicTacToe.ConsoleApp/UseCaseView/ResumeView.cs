using TicTacToe.ConsoleApp.ConsolesIOs;
using TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;
using TicTacToe.Models;

namespace TicTacToe.ConsoleApp.UseCaseView;

internal class ResumeView
{
    private readonly Game _game;

    public ResumeView(Game game)
    {
        _game = game;
    }

    internal bool Interact()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(new MessageView(Views.MessageType.RESUME).ToString());
        if (yesNoDialog.IsAffirmative())
        {
            _game.NewGame();
        }

        return yesNoDialog.IsAffirmative();
    }
}