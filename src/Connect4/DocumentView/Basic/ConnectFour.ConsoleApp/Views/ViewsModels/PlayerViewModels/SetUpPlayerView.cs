using ConnectFour.Models;
using ConnectFour.Types;

namespace ConnectFour.ConsoleApp.Views.ViewsModels.PlayerViewModels;
internal class SetUpPlayerView
{
    internal void SetPlayers(Game game)
    {
        int players;
        Error error;
        do
        {
            players = ConsoleIOs.ConsoleIO.Instance.ReadInt(Message.NumOfPlayers.GetMessage());
            error = game.GetErrorToSetNum(players);
            new ErrorView().WriteLine(error);
        } while (!error.IsNull());

        game.SetPlayer(players);
    }
}
