using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DependencyInversionPrinciple
{
    internal class DCardPayment : IDPayment
    {
        public void SavePaymentDetails()
        {
            throw new NotImplementedException();
        }
    }
}
