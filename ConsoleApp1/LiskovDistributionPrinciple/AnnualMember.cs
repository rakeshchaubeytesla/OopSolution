using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LiskovDistributionPrinciple
{
    public class AnnualMember : Member
    {
        public AnnualMember(string name) : base(name)
        {
        }

        public override void addToDatabase()
        {
            throw new NotImplementedException();
        }

        public override void makeBooking()
        {
            throw new NotImplementedException();
        }
    }
}
