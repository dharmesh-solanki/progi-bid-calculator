using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgiBidCalculator.Domain.Services.Interfaces
{
    public interface IVehicleType
    {
        abstract decimal BasicMinimumFeeAmount { get; }
        abstract decimal BasicMaximumFeeAmount { get; }
        abstract decimal SpecialFeePercentage { get; }
        abstract decimal VehiclePrice { get; }
    }
}
