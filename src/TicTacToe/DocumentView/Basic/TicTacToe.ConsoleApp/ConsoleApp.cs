using TicTacToe;
using TicTacToe.Models;
using TicTacToe.Views;

public class ConsoleTicTacToe : Main
{
    protected override ViewGame CreateView(Game game)
    {
        return new ConsoleView(game);
    }

    public static void Main(string[] args)
    {
        new ConsoleTicTacToe().Play();
    }
}
