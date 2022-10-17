namespace TicTacToe.Models
{
    internal class MachinePlayer : Player
    {
        public MachinePlayer(Board board, Token token) : base(board, token)
        {
        }

        protected override Coordinate ReadCoordinate(MessageType messageType)
        {
            return new Coordinate().ReadRandom(messageType);
        }
    }
}
