using AkarSoftware.Parking.Core.Extentions.FluentValidation.ComplexTypes;
using FluentValidation.Results;

namespace AkarSoftware.Parking.Core.Extentions.FluentValidation
{
    public static class FluentValidationExtentions
    {
        public static List<ErrorModel> GetErrors(this ValidationResult result)
        {
            var errors = new List<ErrorModel>();
            foreach (var item in result.Errors)
                errors.Add(new ErrorModel { PropertyName = item.PropertyName, ErrorDescription = item.ErrorMessage });
            
            return errors;
        }

    }
}
