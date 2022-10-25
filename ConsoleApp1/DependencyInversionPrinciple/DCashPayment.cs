using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DependencyInversionPrinciple
{
    public class DCashPayment : IDPayment
    {
        public void SavePaymentDetails()
        {
            throw new NotImplementedException();
        }
    }
}
