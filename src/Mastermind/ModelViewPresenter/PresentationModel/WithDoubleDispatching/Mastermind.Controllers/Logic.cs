using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.Controllers;

public class Logic
{
    private readonly Game _game;
    private readonly Dictionary<StateCode, Controller> _controllers;

    public Logic()
    {
        _game = new Game();
        _controllers = new Dictionary<StateCode, Controller>
        {
            { StateCode.Initial, new StartController(_game, _game.GetStateCode()) },
            { StateCode.InGame, new PlayController(_game, _game.GetStateCode()) },
            { StateCode.Resume, new ResumeController(_game, _game.GetStateCode()) },
            { StateCode.OutGame, null }
        };
    }

    public Controller Controller => _controllers[_game.GetStateCode()];
}
