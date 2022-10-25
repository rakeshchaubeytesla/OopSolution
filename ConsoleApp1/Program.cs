using ConsoleApp1.OpenForExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = new CashPayment();
            MakePayment(payment);
        }

        public static void MakePayment(IPayment payment)
        {
            payment.MakePayment();
        }
    }
}
