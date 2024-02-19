using ProgiBidCalculator.Domain.Services.Interfaces;

namespace ProgiBidCalculator.Domain
{
    public class CommonVehicle : IVehicleType
    {
        const decimal SPECIAL_FEE_PERCENTAGE = 2;
        public decimal BasicMinimumFeeAmount => 10;
        public decimal BasicMaximumFeeAmount => 50;
        public decimal SpecialFeePercentage => SPECIAL_FEE_PERCENTAGE;
        public decimal VehiclePrice { get; }
        public CommonVehicle(decimal price)
        {
            VehiclePrice = price;
        }
    }
}
