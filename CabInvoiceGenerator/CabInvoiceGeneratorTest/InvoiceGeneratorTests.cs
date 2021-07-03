using NUnit.Framework;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    public class InvoiceGeneratorTests
    {
        //Invoice Generator Refrence
        InvoiceGenerator invoice = null;
        /// <summary>
        /// UC1-TC1.1:-Given Distance and Time ,the invoice Generator Should Return the Total fare for journey
        /// </summary>
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //Arrange Creating instance of invoice Genertor for Normal Ride
            invoice = new InvoiceGenerator(RideType.NORMAL);
            double distance = 10;
            int time = 50;
            //Act:-Calculating the fare
            double fare = invoice.CalculateFare(distance, time);
            double expected = 150;
            //Assert
            Assert.AreEqual(expected, fare);
        }
    }
}