using TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;
using TicTacToe.Models.Types;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp.UseCaseView.PlayerViews;

internal class MachinePlayer : PlayerView
{
    internal override Coordinate GetCoordinate(MessageType messageType)
    {
        return new CoordinateView().ReadRandom(messageType);
    }
}
