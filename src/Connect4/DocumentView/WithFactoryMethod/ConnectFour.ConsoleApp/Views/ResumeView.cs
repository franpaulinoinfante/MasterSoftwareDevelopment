using ConnectFour.GameViews;
using ConnectFour.Models;

internal class ResumeView : WithGameView
{
    public ResumeView(Game game) : base(game)
    {
    }

    internal bool Interact()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(Message.Resume.GetMessage());
        if (yesNoDialog.IsAffirmative())
        {
            _game.NewGame();
        }

        return yesNoDialog.IsAffirmative();
    }
}