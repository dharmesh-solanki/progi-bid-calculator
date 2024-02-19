using ProgiBidCalculator.Domain.BidCalculatorModels;

namespace ProgiBidCalculator.Domain.Services.Interfaces
{
    public interface IBidCalculatorService
    {
        BidCalculationResponse CalculateFee(BidCalculationRequest request);
    }
}
