using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LiskovDistributionPrinciple
{
    public abstract class Member : IDatabase,IBooking
    {
        string name;
        public Member(string name)
        {
            this.name = name;
        }

        //public void AddToDatabase()
        //{
        //    throw new NotImplementedException();
        //}

        //public void makeBooking()
        //{
        //    throw new NotImplementedException();
        //}
        public abstract void addToDatabase();

        public abstract void makeBooking();
    }

    public interface IDatabase
    {
        void addToDatabase();
    }

    public interface IBooking
    {
        void makeBooking();
    }


}
