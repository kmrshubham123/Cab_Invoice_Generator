using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome to the Cab Invoice Generator****");
            InvoiceGenerator invoiceNormal = new InvoiceGenerator(RideType.NORMAL);
            invoiceNormal.CalculateFare(10, 5);
            Console.WriteLine("Normal Fare:- " + invoiceNormal.CalculateFare(10, 5));
            InvoiceGenerator invoicePremimum = new InvoiceGenerator(RideType.PREMIUM);
            invoicePremimum.CalculateFare(10, 5);
            Console.WriteLine("Premium Fare:- " +invoicePremimum.CalculateFare(10, 5));
        }
    }
}
