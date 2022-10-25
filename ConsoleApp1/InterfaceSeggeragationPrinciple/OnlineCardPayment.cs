using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfaceSeggeragationPrinciple
{
    internal class OnlineCardPayment : IPaymentcs,ICardPayment
    {
        public void SaveCardDetails()
        {
            //Save card details
            throw new NotImplementedException();
        }

        public void savePaymentDetails()
        {
            //Save amount and user details
            throw new NotImplementedException();
        }
    }
}
