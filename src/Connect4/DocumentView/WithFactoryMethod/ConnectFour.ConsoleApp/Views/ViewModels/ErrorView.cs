using ConnectFour.Types;

internal class ErrorView : ConnectFour.GameViews.ErrorView
{
    public ErrorView(Error error) : base(error)
    {
    }

    public override void WriteLine()
    {
        if (!_error.IsNull())
        {
            ConsoleIO.Instance.WriteLine(ToString());
        }
    }

    public void WriteLine(int colunm)
    {
        if (!_error.IsNull())
        {
            ConsoleIO.Instance.WriteLine(ToString().Replace("#colunm", $"{colunm + 1}"));
        }
    }
}
