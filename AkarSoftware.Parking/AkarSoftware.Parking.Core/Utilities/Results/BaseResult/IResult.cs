using AkarSoftware.Parking.Core.Extentions.FluentValidation.ComplexTypes;
using AkarSoftware.Parking.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Parking.Core.Utilities.Results.BaseResult
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Message { get;}
        public List<ErrorModel> Errors { get; }


    }
}
