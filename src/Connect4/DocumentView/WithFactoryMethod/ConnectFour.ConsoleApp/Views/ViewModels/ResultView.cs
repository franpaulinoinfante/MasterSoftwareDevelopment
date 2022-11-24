internal class ResultView
{
    internal void WriteLine(bool isWinner, string token)
    {
        if (isWinner)
        {
            new MessageView().WriteLine(ConnectFour.GameViews.Message.PlayerWin, token);
        }
        else
        {
            new MessageView().WriteLine(ConnectFour.GameViews.Message.PlayersTie);
        }
    }
}