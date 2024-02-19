using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgiBidCalculator.Domain.Services.Interfaces
{
    public interface IVehicleFeesService
    {
        const decimal StorageFee = 100;
        const decimal BasicFeePercentage = 10;
        decimal GetBasicUserFee();
        decimal GetSpecialFee();
        decimal GetAssociationFee();
        decimal GetStorageFee();
    }
}
