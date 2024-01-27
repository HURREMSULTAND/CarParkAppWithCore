namespace AkarSoftware.Parking.Core.Utilities.Results.BaseResult
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
