using ConnectFour.ConsoleApp.ConsoleIOs;
using ConnectFour.ConsoleApp.Views.ViewsModels;
using ConnectFour.Models;

namespace ConnectFour.ConsoleApp.Views;

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
        yesNoDialog.Read(Message.Resume.GetMessage());
        if (yesNoDialog.IsAffirmative())
        {
            _game.Reset();
        }
        return yesNoDialog.IsAffirmative();
    }
}