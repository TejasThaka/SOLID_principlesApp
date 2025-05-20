using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalApp.Services
{
    public interface IInvoiceSender
    {
        void Send(string invoice);
    }
}
