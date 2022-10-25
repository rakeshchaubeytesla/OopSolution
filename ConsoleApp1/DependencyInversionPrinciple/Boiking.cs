using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DependencyInversionPrinciple
{
    
    public class Boiking
    {
        private readonly IDPayment payment;
        public Boiking(IDPayment _payment)
        {
            this.payment = _payment;
        }

        public void getOutPut()
        {
            this.payment.SavePaymentDetails();
        }
    }
}
