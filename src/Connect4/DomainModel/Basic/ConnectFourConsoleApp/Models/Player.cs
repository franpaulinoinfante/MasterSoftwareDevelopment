using ConnectFourConsoleApp;
using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Types;

internal class Player
{
    private readonly Token _token;
    private readonly Board _board;

    public Player(Board board, Token token)
    {
        _board = board;
        _token = token;
    }

    internal Token Token => _token;

    internal void Insert()
    {
        int colunmToInsert;
        ErrorCode errorCode;
        do
        {
            colunmToInsert = ConsoleIO.GetInstance().ReadInt(MessageCode.EnterColunm.GetMessage()) - 1;
            errorCode = GetErrorCodeToInsert(colunmToInsert);
            errorCode.WriteLine();
        } while (!errorCode.IsNull());
        _board.Insert(colunmToInsert, _token);
    }

    private ErrorCode GetErrorCodeToInsert(int colunmToInsert)
    {
        if (!new Coordinate().IsValid(colunmToInsert))
        {
            return ErrorCode.WrongColunm;
        }
        if (_board.IsOccupied(colunmToInsert))
        {
            return ErrorCode.ColunmIsComplete;
        }
        return ErrorCode.Null;
    }

    internal void SingVictory()
    {
        MessageCode.Winner.WriteLine(_token.ToString());
    }
}