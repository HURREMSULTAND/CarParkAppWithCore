namespace AkarSoftware.Parking.Core.Utilities.Pagination.ComplexTypes
{
    public class PagerResultViewModel<T>
    {
        public PagerResultViewModel(MetaData metaData, T data)
        {
            MetaData = metaData;
            Data = data;
        }

        public MetaData MetaData { get; }
        public T Data { get; }

    }
}
