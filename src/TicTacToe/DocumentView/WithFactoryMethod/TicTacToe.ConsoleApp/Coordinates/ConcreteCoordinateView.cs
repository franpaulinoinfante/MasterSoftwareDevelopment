using TicTacToe.Utils.Coordinates;

namespace TicTacToe.ConsoleApp.Coordinates;

internal class ConcreteCoordinateView
{
    internal ConcreteCoordinate Read(string title)
    {
        ConsoleIO consoleIO = ConsoleIO.GetInstance();
        consoleIO.WriteLine(title);
        int row = consoleIO.ReadInt(ConcreteCoordinate.ROW) - 1;
        int column = consoleIO.ReadInt(ConcreteCoordinate.COLUNM) - 1;
        return new ConcreteCoordinate(row, column);
    }
}
