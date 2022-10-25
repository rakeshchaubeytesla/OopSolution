using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfaceSeggeragationPrinciple
{
    internal class UPIPayment : IPaymentcs, ICardPayment
    {
        public void SaveCardDetails()
        {
            throw new NotImplementedException();
        }

        public void savePaymentDetails()
        {
            throw new NotImplementedException();
        }
    }
}
