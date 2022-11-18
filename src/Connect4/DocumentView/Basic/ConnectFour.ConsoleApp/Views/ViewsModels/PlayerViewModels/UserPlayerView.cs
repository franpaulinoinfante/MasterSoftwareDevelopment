using ConnectFour.ConsoleApp.ConsoleIOs;
using ConnectFour.Models;
using ConnectFour.Types;
using ConnectFour.Utils;

namespace ConnectFour.ConsoleApp.Views.ViewsModels.PlayerViewModels;

internal class UserPlayerView : PlayerView
{
    public UserPlayerView(Game game) : base(game)
    {
    }

    protected override int GetColunm()
    {
        int colunm;
        Error error;
        do
        {
            colunm = ConsoleIO.Instance.ReadInt(Message.EnterColunmToDrop.GetMessage()) - 1;
            error = GetErrorColunmOutOfRange(colunm);
            new ErrorView().WriteLine(error);
        } while (!error.IsNull());

        return colunm;
    }

    private Error GetErrorColunmOutOfRange(int colunm)
    {
        if (!new Coordinate(row: 0, Coordinate.Colunms - 1).IsValid(colunm))
        {
            return Error.ColunmIsOutOfRange;
        }
        return Error.Null;
    }

    protected override Error GetErrorToDrop(int colunm)
    {
        Error error = base.GetErrorToDrop(colunm);
        new ErrorView().WriteLine(error);
        return error;
    }
}
