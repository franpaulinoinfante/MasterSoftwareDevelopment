using ConnectFour.GameViews;
using ConnectFour.Models;
using ConnectFour.Types;

internal class PlayerConfigurationView
{
    internal void SetPlayer(Game game)
    {
        int numOfPlayers;
        Error error;
        do
        {
            numOfPlayers = ConsoleIO.Instance.ReadInt(Message.EnterNumOfPlayers.GetMessage());
            error = game.GetErrorToSetUpNumOfPlayer(numOfPlayers);
            new ErrorView(error).WriteLine();
        } while (!error.IsNull());

        game.SetPlayer(numOfPlayers);
    }
}