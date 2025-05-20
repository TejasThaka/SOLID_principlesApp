using SolidPrincipalApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalApp.Services
{
    public class OrderProcessor
    {
        private readonly IInvoiceGenerator _generator;
        private readonly IInvoiceSender _sender;

        public OrderProcessor(IInvoiceGenerator generator, IInvoiceSender sender)
        {
            _generator = generator;
            _sender = sender;
        }

        public void ProcessOrder(string orderId)
        {
            Order order = new Order { OrderId = orderId };
            string invoice = _generator.Generate(order);
            _sender.Send(invoice);
        }
    }

}
