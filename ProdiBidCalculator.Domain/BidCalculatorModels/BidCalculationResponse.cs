namespace ProgiBidCalculator.Domain.BidCalculatorModels
{
    /// <summary>
    /// Collection of properties of Bid calculation response
    /// </summary>
    public class BidCalculationResponse
    {
        public decimal VehicleBasePrice { get; set; }
        public decimal BasicFees { get; set; }
        public decimal SpecialFees { get; set; }
        public decimal AssociationFees { get; set; }
        public decimal StorageFees { get; set; }
        public decimal Total => VehicleBasePrice + BasicFees + SpecialFees + AssociationFees + StorageFees;
    }
}
