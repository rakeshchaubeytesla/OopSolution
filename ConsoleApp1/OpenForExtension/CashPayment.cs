using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OpenForExtension
{
    internal class CashPayment : IPayment
    {
        public string MakePayment()
        {
            return "CashPayment";
        }
    }
}
