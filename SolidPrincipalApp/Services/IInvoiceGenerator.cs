using SolidPrincipalApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalApp.Services
{
    public interface IInvoiceGenerator
    {
        string Generate(Order order);
    }
}
