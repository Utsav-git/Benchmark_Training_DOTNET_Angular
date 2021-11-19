using System;

namespace _1_Abstract_Account
{
    abstract class Account
    {
       public abstract void cal_interest();
    }
    class Saving: Account 
    {
        public override void cal_interest()
        {
            Console.WriteLine("Interest of Saving Account.");
        }
    }
    class Current : Account 
    {
        public override void cal_interest()
        {
            Console.WriteLine("Interest of Current Account.");
        }
    }
    class FD: Account 
    {
        public override void cal_interest()
        {
            Console.WriteLine("Interest of Fixed Desposit.");
        }
    }
    class Program
    {
        public void find_interest(Account a)
        {
            if(a.GetType() == typeof(Saving))
            {
                Saving s = new Saving();
            }
            if (a.GetType() == typeof(Current))
            {
                Current c = new Current();
            }
            if (a.GetType() == typeof(FD))
            {
                FD f = new FD();
            }
            a.cal_interest();
        }
        static void Main(string[] args)
        {
            Account s = new Saving();
            Account c = new Current();
            Account f = new FD();

            Program p = new Program();

            p.find_interest(f);
            p.find_interest(c);
            p.find_interest(s);
        }
    }
}
