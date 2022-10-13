using TicTacToe.ConsoleApp;
using TicTacToe.Models;
using TicTacToe.Views;

internal class ResumeView : WithGameView
{
    public ResumeView(Game game) : base(game)
    {
    }

    internal bool Interact()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(new MessageView(MessageType.RESUME).ToString());
        if (yesNoDialog.IsAffirmative())
        {
            _game.NewGame();
        }
        return yesNoDialog.IsAffirmative();
    }
}