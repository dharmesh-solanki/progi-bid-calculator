using ProgiBidCalculator.Domain.Services.Interfaces;

namespace ProgiBidCalculator.Domain.BaseCalculator
{
    public class VehicleFeesService : IVehicleFeesService
    {
        private readonly IVehicleType _vehicleType;
        public VehicleFeesService(IVehicleType vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public decimal GetBasicUserFee()
        {
            var basicFee = (_vehicleType.VehiclePrice / IVehicleFeesService.BasicFeePercentage);
            return Math.Clamp(basicFee, _vehicleType.BasicMinimumFeeAmount, _vehicleType.BasicMaximumFeeAmount);
        }

        public decimal GetSpecialFee()
        {
            return _vehicleType.VehiclePrice * _vehicleType.SpecialFeePercentage / 100;
        }
        public decimal GetAssociationFee()
        {
            return _vehicleType.VehiclePrice switch
            {
                >= 1 and <= 500 => 5,
                > 500 and <= 1000 => 10,
                > 1000 and <= 3000 => 15,
                _ => 20 // default value
            };

        }
        public decimal GetStorageFee()
        {
            return IVehicleFeesService.StorageFee;
        }
    }
}
