using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalApp.Model
{
    public class Order
    {
        public string OrderId { get; set; }
        public decimal Amount { get; set; } = 100.00m;
    }

}
