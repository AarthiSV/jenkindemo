using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEg
{
    public class Bank
    {
        long balance;
        public long Balance { get { return balance; } set { balance = value; } }
        public long withdraw(long bal,long y)
        {
            Balance = bal;
                if (y < Balance)
                {
                    Balance = Balance - y;
                    return Balance;
                }
            else
            {
                throw new InvalidOperationException("Withdrawal amount should be less than Available balance");
            }
 
        }
        public long credit(long bal,long y)
        {
            Balance = bal;
            Balance = Balance + y;
            return Balance;
        }
    }
}
