using TicTacToe.Models;

namespace TicTacToe.Views;

public abstract class ViewGame : WithViewGame
{
    public ViewGame(Game game) : base(game)
    {

    }

    public abstract void Play();

    public abstract bool Resume();

    public abstract void Start();
}
