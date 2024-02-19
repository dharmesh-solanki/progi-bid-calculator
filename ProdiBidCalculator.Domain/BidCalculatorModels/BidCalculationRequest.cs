using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProgiBidCalculator.Domain.BidCalculatorModels
{
    /// <summary>
    /// Collection of properties of Bid calculation request
    /// </summary>
    public class BidCalculationRequest
    {
        /// <summary>
        /// Vehicle base price
        /// </summary>
        [Required]
        public decimal VehicleBasePrice { get; set; }

        /// <summary>
        /// Vehicle type
        /// </summary>
        [Required]
        public string? VehicleType { get; set; }
    }
}
