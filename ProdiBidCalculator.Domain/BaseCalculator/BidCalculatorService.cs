using ProgiBidCalculator.Domain.BidCalculatorModels;
using ProgiBidCalculator.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgiBidCalculator.Domain.BaseCalculator
{
    public class BidCalculatorService : IBidCalculatorService
    {
        public BidCalculationResponse CalculateFee(BidCalculationRequest request)
        {
            VehicleFeesService vehicleFees;
            if (string.Compare(request.VehicleType, "common", true) == 0)
            {
                vehicleFees = new VehicleFeesService(new CommonVehicle(request.VehicleBasePrice));
            }
            else if (string.Compare(request.VehicleType, "luxury", true) == 0)
            {
                vehicleFees = new VehicleFeesService(new LuxuryVehicle(request.VehicleBasePrice));
            }
            else
                throw new Exception("Unsupported vehicle type.");

            return new BidCalculationResponse
            {
                BasicFees = vehicleFees.GetBasicUserFee(),
                SpecialFees = vehicleFees.GetSpecialFee(),
                AssociationFees = vehicleFees.GetAssociationFee(),
                StorageFees = vehicleFees.GetStorageFee(),
                VehicleBasePrice = request.VehicleBasePrice
            };
        }
    }
}
