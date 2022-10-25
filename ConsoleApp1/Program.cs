using ConsoleApp1.DependencyInversionPrinciple;
using ConsoleApp1.LiskovDistributionPrinciple;
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
            //IPayment payment = new CashPayment();
            //MakePayment(payment);
            // So what we did here is remove the dependency from Boiking class.
            //IDPayment payment = new DOnlineCardPaymen();
            //Boiking boiking = new Boiking(payment);
            //boiking.getOutPut();
            List<IDatabase> members = new List<IDatabase>();
            members.Add(new LifeTimeMember("Rakesh"));
            members.Add(new AnnualMember("Chaubey"));
            members.Add(new Enquiry("Prissha"));

            foreach (var item in members)
            {

            }
        }

        public static void MakePayment(IPayment payment)
        {
            payment.MakePayment();
        }
    }
}
