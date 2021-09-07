using System;

namespace Alaca.Core.Utilities.Result
{
    public class ResultData<TEntity> : IResultData<TEntity>
    {
        public ResultData()
        {

        }
        public ResultData(bool success)
        {

        }
        public ResultData(bool success,string message):this(success)
        {
            Message = message;
        }
        public ResultData(bool success, TEntity data)
        {
            Success = success;
            Data = data;
        }
        public ResultData(bool success, string message, TEntity data) : this(success, data)
        {
            Data = data;
            Message = message;
        }
        public TEntity Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

        public object RecordId { get; set; }

    }
}
