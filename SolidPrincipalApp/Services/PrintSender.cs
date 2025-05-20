using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalApp.Services
{
    public class PrintSender : IInvoiceSender
    {
        public void Send(string invoice)
        {
            Console.WriteLine("Printed Invoice: " + invoice);
        }
    }
}
