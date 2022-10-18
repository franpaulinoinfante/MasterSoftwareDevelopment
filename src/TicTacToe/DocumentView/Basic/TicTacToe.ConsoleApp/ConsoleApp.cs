using TicTacToe.Models;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp;

internal class ConsoleApp : Main
{
    protected override GameView CreateGameView(Game game)
    {
        return new ConsoleGameView(game);
    }

    public static void Main(string[] args)
    {
        new ConsoleApp().Play();
    }
}