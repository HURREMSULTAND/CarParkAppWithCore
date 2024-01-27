using AkarSoftware.Parking.Core.Entities.Abstract;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

namespace AkarSoftware.Parking.Entities.Concrete.Parking
{
    public class ParkLayers : BaseEntity
    {
        public string LayerName { get; set; }
        public int CarParkId { get; set; }

        //Navigation Property
        public CarPark CarPark { get; set; }
        public List<ParkingArea> ParkingAreas { get; set; }
    }
}
