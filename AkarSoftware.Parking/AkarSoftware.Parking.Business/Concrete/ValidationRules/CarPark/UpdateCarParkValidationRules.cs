using AkarSoftware.Parking.Dtos.Concrete.Parking.CarPark;
using FluentValidation;

namespace AkarSoftware.Parking.Business.Concrete.ValidationRules.CarPark
{
    public class UpdateCarParkValidationRules : AbstractValidator<CarParkUpdateDto>
    {
        public UpdateCarParkValidationRules()
        {
            RuleFor(x => x.Id).ExclusiveBetween(1, int.MaxValue).WithMessage("Güncelleme işlemi için id bilgisi zorunludur");
            RuleFor(x => x.AppUserId).ExclusiveBetween(1, int.MaxValue).WithMessage("Güncelleme işlemi için Kullanıcı bilgisi zorunludur");
            RuleFor(x => x.CarParkName).NotEmpty().WithMessage("Güncelleme işlemi için Otopark Adı Bilgisi zorunludur");
        }
    }
}
