using Mastermind.Types;

namespace Mastermind.Models
{
    internal class State
    {
        private StateCode _stateCode;

        public State()
        {
            Reset();
        }

        internal StateCode StateCode { get => _stateCode; }

        internal void Reset()
        {
            _stateCode = StateCode.Initial;
        }

        internal void Next()
        {
            _stateCode++;
        }
    }
}