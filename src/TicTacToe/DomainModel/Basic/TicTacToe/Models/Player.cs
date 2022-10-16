using System.Diagnostics;

internal class Player
{
    private readonly TokenType _token;
    private readonly Board _board;

    public Player(TokenType token, Board board)
    {
        Debug.Assert((token != TokenType.NULL) && (board != null));

        _token = token;
        _board = board;
    }

    public TokenType Token => _token;

    internal void PutToken()
    {
        Coordinate coordinate;
        ErrorType errorType;
        do
        {
            coordinate = new Coordinate().Read(MessageType.ENTER_COORDINATE_TO_PUT);
            errorType = _board.GetErrorTypeToPut(coordinate);
            new Error(errorType).WriteLine();
        } while (errorType != ErrorType.NULL);
        _board.PutToken(coordinate, _token);
    }

    internal void MoveToken()
    {
        ErrorType errorType;
        Coordinate origin;
        do
        {
            origin = new Coordinate().Read(MessageType.COORDINATE_TO_REMOVE);
            errorType = _board.GetErrorTypeToMoveOrigin(origin, _token);
            new Error(errorType).WriteLine();
        } while (errorType != ErrorType.NULL);

        Coordinate target;
        do
        {
            target = new Coordinate().Read(MessageType.COORDINATE_TO_MOVE);
            errorType = _board.GetErrorTypeToMoveTargetCoordinate(origin, target);
            new Error(errorType).WriteLine();
        } while (errorType != ErrorType.NULL);
        _board.MoveToken(origin, target);
    }

    internal bool Resume()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(new Message(MessageType.RESUME).ToString());
        return yesNoDialog.IsAffirmative();
    }
}