namespace AkarSoftware.Parking.Core.Utilities.Pagination.ComplexTypes
{
    public abstract class RequestParameters
    {
        const int MaxPageSize = 24;
        public int PageNumber { get { return (_pageNumber == 0 ? 1 : _pageNumber); } set { _pageNumber = value; } }  
        public int _pageNumber { get; set; }

        private int _pageSize;  
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                if (MaxPageSize < value)
                {
                    _pageSize = MaxPageSize;
                }
                else
                {
                    _pageSize = value;
                }

            }
        }
    }
}
