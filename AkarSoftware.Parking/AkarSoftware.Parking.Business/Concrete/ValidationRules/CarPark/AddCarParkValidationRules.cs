using AkarSoftware.Parking.Dtos.Concrete.Parking.CarPark;
using FluentValidation;

namespace AkarSoftware.Parking.Business.Concrete.ValidationRules.CarPark
{
    public class AddCarParkValidationRules : AbstractValidator<CarParkAddDto>
    {
        public AddCarParkValidationRules()
        {
            RuleFor(x => x.AppUserId).ExclusiveBetween(1, int.MaxValue).WithMessage("Güncelleme işlemi için Kullanıcı bilgisi zorunludur");
            RuleFor(x => x.CarParkName).NotEmpty().WithMessage("Güncelleme işlemi için Otopark Adı Bilgisi zorunludur");
        }
 
    }
}
