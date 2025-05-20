using SolidPrincipalApp.Services;
using System;

class Program
{
    static void Main()
    {
        IInvoiceGenerator invoiceGenerator = new InvoiceGenerator();
        IInvoiceSender emailSender = new EmailSender(); // Switch with PrintSender to print

        OrderProcessor orderProcessor = new OrderProcessor(invoiceGenerator, emailSender);
        orderProcessor.ProcessOrder("Order123....");
    }
}