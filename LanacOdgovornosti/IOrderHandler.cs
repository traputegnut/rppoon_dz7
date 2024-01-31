using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacOdgovornosti
{
    interface IOrderHandler
    {
        IOrderHandler NextHandler { get; set; }
        void ProcessOrder(Order order);
    }
}
