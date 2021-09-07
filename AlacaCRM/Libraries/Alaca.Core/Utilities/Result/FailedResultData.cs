namespace Alaca.Core.Utilities.Result
{
    public class FailedResultData<IEntity> : ResultData<IEntity>
    {
        public FailedResultData() : base(false)
        {
        }
        public FailedResultData(string message) : base(false, message)
        {
        }
        public FailedResultData(IEntity data) : base(false, data)
        {
        }

        public FailedResultData(string Message, IEntity data) : base(false, Message, data)
        {
        }
    }
}
