using Mastermind.Controllers;

namespace Mastermind.GameViews;

public interface IGameView
{
    void Start(StartController startController);
    void Play(PlayController playController);
    bool Resume(ResumeController resumeController);
}
