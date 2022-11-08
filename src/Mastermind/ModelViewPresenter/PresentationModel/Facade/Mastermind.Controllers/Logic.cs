using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.Controllers;

public class Logic
{
    private readonly StartController _startController;
    private readonly PlayController _playController;
    private readonly ResumeController _resumeController;

    public Logic(Game game)
    {
        _startController = new StartController(game);
        _playController = new PlayController(game);
        _resumeController = new ResumeController(game);
    }

    public void NewGame()
    {
        _startController.NewGame();
    }

    public int GetAttempts()
    {
        return _playController.GetAttempts();
    }

    public void AddProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        _playController.AddproposedCombination(colorCodes);
    }

    public ErrorCode GetErrorCodeToProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        return _playController.GetErrorCodeToProposedCombination(colorCodes);
    }

    public void CheckResult()
    {
        _playController.CheckResult();
    }

    public IEnumerable<ColorCode> GetPropusedCombination(int position)
    {
        return _playController.GetProposedCombination(position);
    }

    public int GetBlacks(int position)
    {
        return _playController.GetBlacks(position);
    }

    public int GetWhites(int position)
    {
        return _playController.GetWhites(position);
    }

    public bool IsFinished()
    {
        return _playController.IsFinished();
    }

    public bool IsWinner()
    {
        return _playController.IsWinner();
    }
}
