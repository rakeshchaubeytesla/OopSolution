using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfaceSeggeragationPrinciple
{
    public interface ICardPayment
    {
        //Will save card number and card details
        void SaveCardDetails();
    }
}
