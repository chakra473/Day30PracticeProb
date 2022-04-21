using NUnit.Framework;
using Day30;

namespace TestProject1
{
    public class Tests
    {
        CabInvoiceGenerator invoiceGenerator = null;

        /// <summary>
        /// Test case for Checking Calculate fare Function
        /// </summary>
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new CabInvoiceGenerator(RydeType.NORMAL);
            double distance = 2.0;
            int time = 5;

            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }
    }
}