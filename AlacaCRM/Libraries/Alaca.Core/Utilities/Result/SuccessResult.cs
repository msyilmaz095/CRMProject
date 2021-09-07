using System;

namespace Alaca.Core.Utilities.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {

        }
        public SuccessResult(string message) : base(true, message)
        {

        }
        public SuccessResult(object recordId) : base(true, recordId)
        {

        }
        public SuccessResult(string message, object recordId) : base(true, message, recordId)
        {
        }
    }
}
