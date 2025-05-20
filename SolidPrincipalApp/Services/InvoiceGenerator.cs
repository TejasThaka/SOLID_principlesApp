using SolidPrincipalApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalApp.Services
{
    public class InvoiceGenerator : IInvoiceGenerator
    {
        public string Generate(Order order)
        {
            return $"Invoice for Order: {order.OrderId}, Amount: {order.Amount}";
        }
    }
}
