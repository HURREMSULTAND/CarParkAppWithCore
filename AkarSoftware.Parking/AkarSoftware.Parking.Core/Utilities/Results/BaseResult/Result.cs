using AkarSoftware.Parking.Core.Extentions.FluentValidation.ComplexTypes;
using AkarSoftware.Parking.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Parking.Core.Utilities.Results.BaseResult
{
    public class Result : IResult
    {
        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
        public List<ErrorModel> Errors { get; set; }

        public Result(ResultStatus status, string StatusMessages, IEnumerable<ErrorModel> Errors) : this(status, StatusMessages)
        {
            Errors = Errors;
        }

        public Result(ResultStatus status, string StatusMessages) : this(status)
        {
            this.Message = StatusMessages;
        }

        public Result(ResultStatus status)
        {
            this.ResultStatus = status;
        }

        public Result(ResultStatus status, IEnumerable<ErrorModel> Errors) : this(status, string.Empty, Errors)
        {

        }
    }
}
