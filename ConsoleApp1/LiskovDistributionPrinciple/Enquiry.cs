using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LiskovDistributionPrinciple
{
    public class Enquiry : IDatabase
    {
        public Enquiry(string name)
        {

        }

        public void addToDatabase()
        {
            throw new NotImplementedException();
        }

        //public override void makeBooking()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
