using Mastermind.Controllers;

namespace Mastermind.GameViews;

public abstract class GameView
{
    private StartController _startController;
    private PlayController _playController;
    private ResumeController _resumeController;

    public GameView(StartController startController, PlayController playController, ResumeController resumeController)
    {
        _startController = startController;
        _playController = playController;
        _resumeController = resumeController;
    }

    public abstract void Start();
    public abstract void Play();
    public abstract bool Resume();
}
