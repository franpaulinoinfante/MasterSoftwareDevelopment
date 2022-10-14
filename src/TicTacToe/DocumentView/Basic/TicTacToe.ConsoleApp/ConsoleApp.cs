using TicTacToe;
using TicTacToe.Models;
using TicTacToe.Views;

public class ConsoleApp : Main
{
    protected override ViewGame CreateView(Game game)
    {
        return new ConsoleTicTacToe(game);
    }

    public static void Main(string[] args)
    {
        new ConsoleApp().Play();
    }
}
