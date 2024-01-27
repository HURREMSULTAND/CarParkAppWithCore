using AkarSoftware.Parking.Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace AkarSoftware.Parking.Entities.Concrete.Parking
{
    public class CarPark : BaseEntity
    {
        public string CarParkName { get; set; } // Nvarchar(MAx)
        public int AppUserId { get; set; }

        // Navigation Property
        public List<ParkLayers> ParkLayers { get; set; }
    }
}
