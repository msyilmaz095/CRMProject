namespace Alaca.Core.Utilities.Result
{
    public class SuccessResultData<IEntity> : ResultData<IEntity>
    {
        public SuccessResultData() : base(true)
        {
        }
        public SuccessResultData(IEntity data) : base(true, data)
        {
        }
        public SuccessResultData(string Message, IEntity data) : base(true, Message, data)
        {
        }
    }
}
