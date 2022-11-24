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
        yesNoDialog.Read(Message.Resume.GetToString());
        if (yesNoDialog.IsAffirmative())
        {
            _game.Reset();
        }

        return yesNoDialog.IsAffirmative();
    }
}