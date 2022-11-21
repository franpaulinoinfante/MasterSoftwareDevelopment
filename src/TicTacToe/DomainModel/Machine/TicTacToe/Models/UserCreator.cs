namespace TicTacToe.Models;

internal class UserCreator
{
    private static UserCreator? _instance;

    public static UserCreator GetInstante()
    {
        if (_instance == null)
        {
            _instance = new UserCreator();
        }
        return _instance;
    }

    internal Player GetUser(int position, int numberUsers, Board board)
    {
        if (position < numberUsers)
        {
            return new UserPlayer(board, Enum.GetValues<Token>()[position]);
        }
        else
        {
            return new MachinePlayer(board, Enum.GetValues<Token>()[position]);
        }
    }
}