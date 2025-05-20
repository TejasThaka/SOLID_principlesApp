using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalApp.Services
{
    public class EmailSender : IInvoiceSender
    {
        public void Send(string invoice)
        {
            Console.WriteLine("Email Sent: " + invoice);
        }
    }
}
