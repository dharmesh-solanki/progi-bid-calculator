using ProgiBidCalculator.Domain.BaseCalculator;

namespace ProgiBidCalculator.TestCases
{
    [TestClass]
    public class VehiclePriceCalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var vehiclePrice = 398M;
            var expectedFees = 550.76M;

            BidCalculatorService service = new();
            var result = service.CalculateFee(new Domain.BidCalculatorModels.BidCalculationRequest() { VehicleBasePrice = vehiclePrice, VehicleType = "common" });
            Assert.AreEqual(result.Total, expectedFees);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var vehiclePrice = 501M;
            var expectedFees = 671.02M;

            BidCalculatorService service = new();
            var result = service.CalculateFee(new Domain.BidCalculatorModels.BidCalculationRequest() { VehicleBasePrice = vehiclePrice, VehicleType = "common" });
            Assert.AreEqual(result.Total, expectedFees);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var vehiclePrice = 57M;
            var expectedFees = 173.14M;

            BidCalculatorService service = new();
            var result = service.CalculateFee(new Domain.BidCalculatorModels.BidCalculationRequest() { VehicleBasePrice = vehiclePrice, VehicleType = "common" });
            Assert.AreEqual(result.Total, expectedFees);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var vehiclePrice = 1800M;
            var expectedFees = 2167.00M;

            BidCalculatorService service = new();
            var result = service.CalculateFee(new Domain.BidCalculatorModels.BidCalculationRequest() { VehicleBasePrice = vehiclePrice, VehicleType = "luxury" });
            Assert.AreEqual(result.Total, expectedFees);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var vehiclePrice = 1100M;
            var expectedFees = 1287.00M;

            BidCalculatorService service = new();
            var result = service.CalculateFee(new Domain.BidCalculatorModels.BidCalculationRequest() { VehicleBasePrice = vehiclePrice, VehicleType = "common" });
            Assert.AreEqual(result.Total, expectedFees);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var vehiclePrice = 1000000M;
            var expectedFees = 1040320.00M;

            BidCalculatorService service = new();
            var result = service.CalculateFee(new Domain.BidCalculatorModels.BidCalculationRequest() { VehicleBasePrice = vehiclePrice, VehicleType = "luxury" });
            Assert.AreEqual(result.Total, expectedFees);
        }
    }
}