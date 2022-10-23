using Mastermind.Models;

class ConsoleApp
{
    private Game _game;
    private GameView _gameView;

    public ConsoleApp()
    {
        _game = new Game();
        _gameView = new GameView(_game);
    }

    internal void Play()
    {
        do
        {
            _gameView.Start();
            _gameView.Play();
        } while (_gameView.Resume());
    }

    public static void Main(string[] args)
    {
        new ConsoleApp().Play();
    }
}