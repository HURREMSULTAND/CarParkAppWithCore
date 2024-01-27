using AkarSoftware.Parking.Core.Entities.Abstract;

namespace AkarSoftware.Parking.Entities.Concrete.Parking
{
    public class ParkingArea : BaseEntity
    {
        public string AreaName { get; set; }  // A1, A2 A3
        public int LayerId { get; set; }
        public bool IsEmpty { get; set; }
        public string CarPlate {  get; set; }
        
        // Navigation Property
        public ParkLayers Layer { get; set; }   
    }
}
