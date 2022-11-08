using System.Diagnostics;

public class YesNoDialog
{
    private const char AFFIRMATIVE = 'y';
    private const char NEGATIVE = 'n';
    private static readonly string SUFFIX = $"? ({YesNoDialog.AFFIRMATIVE}/{YesNoDialog.NEGATIVE})";
    private static readonly string MESSAGE = $"The value must be: ({YesNoDialog.AFFIRMATIVE} or {YesNoDialog.NEGATIVE})";

    private string _answer;

    public void Read(string? message)
    {
        Debug.Assert(message != null);

        ConsoleIO consoleIO = ConsoleIO.GetInstance();
        bool ok;
        do
        {
            consoleIO.Write(message);
            _answer = consoleIO.ReadString(YesNoDialog.SUFFIX);

            ok = IsAffirmative() || IsNegative();
            if (!ok)
            {
                consoleIO.WriteLine(YesNoDialog.MESSAGE);
            }
        } while (!ok);
    }

    public bool IsAffirmative() => GetAnswer() == YesNoDialog.AFFIRMATIVE;

    private char GetAnswer()
    {
        return char.ToLower(_answer.ToCharArray()[0]);
    }

    public bool IsNegative() => GetAnswer() == YesNoDialog.NEGATIVE;
}
