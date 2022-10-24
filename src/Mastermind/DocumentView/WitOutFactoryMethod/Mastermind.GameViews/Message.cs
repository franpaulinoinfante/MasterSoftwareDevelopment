namespace Mastermind.GameViews;

public enum Message
{
    Title,
    SecrectCombination,
    ProposedCombination,
    Attempts,
    Result,
    Winner,
    Looser,
    Resume
}

public static class MessageExtension
{
    private static readonly string[] Messages =
    {
        "----- MASTERMIND -----",
        "****",
        "Propose a combination: ",
        "#attempts attempt(s): ",
        " --> #blacks blacks and #whites whites",
        "You've won!!! ;-)",
        "You've lost!!! :-(",
        "Do you want to continue"
    };

    public static string GetString(this Message message)
    {
        return Messages[(int)message];
    }
}
