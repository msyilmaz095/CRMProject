namespace Alaca.Core.Utilities.Result
{
    public class FailedResult: Result
    {
        public FailedResult() : base(false)
        {

        }
        public FailedResult(string message) : base(false, message)
        {

        }
    }
}
