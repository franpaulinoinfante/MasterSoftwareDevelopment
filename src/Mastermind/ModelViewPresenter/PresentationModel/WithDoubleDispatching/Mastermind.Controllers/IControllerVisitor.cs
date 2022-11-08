namespace Mastermind.Controllers;

public interface IControllerVisitor
{
    void Visit(StartController startController);
    void Visit(PlayController playController);
    bool Visit(ResumeController resumeController);
}
