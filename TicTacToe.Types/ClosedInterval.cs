namespace TicTacToe.Types
{
    public class ClosedInterval
    {
        private readonly int _inferior;
        private readonly int _superior;

        public ClosedInterval(int inferior, int superior)
        {
            _inferior = inferior;
            _superior = superior;
        }

        internal bool IsIncluide(int value)
        {
            return _inferior <= value && value <= _superior;
        }
    }
}