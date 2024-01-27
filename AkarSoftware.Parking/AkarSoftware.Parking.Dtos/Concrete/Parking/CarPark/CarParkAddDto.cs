﻿using AkarSoftware.Parking.Core.Dtos.Abstract;

namespace AkarSoftware.Parking.Dtos.Concrete.Parking.CarPark
{
    public class CarParkAddDto : BaseDto
    {
        public string CarParkName { get; set; } // Nvarchar(MAx)
        public int AppUserId { get; set; }
    }
}
