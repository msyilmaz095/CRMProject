namespace Alaca.Core.Utilities.Result
{
    public interface IResultData<TEntity> : IResult
    {
        public TEntity Data { get; }
    }
}
