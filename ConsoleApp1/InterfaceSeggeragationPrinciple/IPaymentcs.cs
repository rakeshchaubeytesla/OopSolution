using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InterfaceSeggeragationPrinciple
{
    internal interface IPaymentcs
    {
        //This will save payment details such as Name address Amount. 
        //This msthid is designed keeping in mind customer will always make cash payment.
        //But future holds a surprise for us.
        //InterfaceSeggeragationPrinciple clearly says that Dont force client to implment interface which is irrelevant to it.
        //If tmw we have another payment such as card netbankking.THen i have to write a method
        //Save card details and i am compelled to write save card details for cashpayment class 
        //because of interface.Where as savecard has no relevance to cash payment. That is some thinf InterfaceSeggeragationPrinciple tell 
        //you to seggeregate interface. It says creates a new interface and lets the child inherit both the interface where it is required

        void savePaymentDetails();

        //If i am implemnt below method here CashPayment is compiled to implent save card details.
        //Which is an unecessary implementation.Better is we create new interface
        //void SaveCardDetails();
    }
}
