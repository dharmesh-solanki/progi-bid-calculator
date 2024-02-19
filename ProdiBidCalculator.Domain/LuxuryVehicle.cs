using ProgiBidCalculator.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgiBidCalculator.Domain
{
    public class LuxuryVehicle : IVehicleType
    {
        const decimal SPECIAL_FEE_PERCENTAGE = 4;
        public decimal BasicMinimumFeeAmount => 25;
        public decimal BasicMaximumFeeAmount => 200;
        public decimal SpecialFeePercentage => SPECIAL_FEE_PERCENTAGE;
        public decimal VehiclePrice { get; }
        public LuxuryVehicle(decimal price)
        {
            VehiclePrice = price;
        }
    }
}
