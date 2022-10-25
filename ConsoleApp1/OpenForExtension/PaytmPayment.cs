using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OpenForExtension
{
    internal class PaytmPayment : IPayment
    {
        public string MakePayment()
        {
            return "PaytmPayment";
        }
    }
}
