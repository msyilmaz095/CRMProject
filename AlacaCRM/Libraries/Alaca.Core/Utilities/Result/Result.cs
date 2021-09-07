using System;

namespace Alaca.Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result()
        {

        }
        public Result(bool sucess)
        {
            Success = sucess;
        }
        public Result(bool sucess, object recordId) : this(sucess)
        {
            RecordId = recordId;
        }
        public Result(bool sucess, string message) : this(sucess)
        {
            Message = message;
        }
        public Result(bool sucess, string message, object recordId) : this(sucess, recordId)
        {
            Message = message;
            RecordId = recordId;
        }
        public bool Success { get; set; }

        public string Message { get; set; }
        public object RecordId { get; set; }
    }
}
