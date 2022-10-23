using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Types;

internal class ColorView
{
    internal string GetAllInitials()
    {
        Color[] colors = Enum.GetValues<Color>();
        string initials = string.Empty;
        for (int i = 0; i < colors.Length; i++)
        {
            initials += colors[i].GetInitial();
                
        }
        return initials;
    }

    internal char GetInitial(Color color)
    {
        return color.ToString().ToLower()[0];
    }

    internal void Write(Color color)
    {
        if (!color.IsNull())
        {
            ConsoleIO.GetInstance().Write(GetInitial(color));
        }
    }
}