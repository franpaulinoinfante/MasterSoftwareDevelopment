using ConnectFour.ConsoleApp.Views.ViewModels;
using ConnectFour.GameViews;
using ConnectFour.Models;
using ConnectFour.Types;
using ConnectFour.Utils;

internal class UserPlayerView : PlayerView
{
    public UserPlayerView(Game game) : base(game)
    {
    }

    protected override int ReadColunm()
    {
        int colunm;
        Error error;
        do
        {
            colunm = ConsoleIO.Instance.ReadInt(Message.EnterColunmToDrop.GetToString()) - 1;
            error = GetErrorToOutOfRange(colunm);
            new ErrorView(error).WriteLine();
        } while (!error.IsNull());

        return colunm;
    }

    private Error GetErrorToOutOfRange(int colunm)
    {
        if (!new Coordinate(row: 0, Coordinate.MaxColumns - 1).IsValid(colunm))
        {
            return Error.TheColunmIsOutOfRange;
        }

        return Error.Null;
    }

    protected override Error GetErrorToDrop(int colunm)
    {
        Error error = base.GetErrorToDrop(colunm);
        new ErrorView(error).WriteLine(colunm);
        return error;
    }
}