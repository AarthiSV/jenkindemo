using System;

namespace TestingEg
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            long bal=50000;
            long x=b.withdraw(bal,10000);
            long y = b.credit(bal,20000);
            Console.WriteLine("After Withdraw:{0}", x);
            Console.WriteLine("After credit:{0}", y);
            Console.WriteLine("Success");
        }
    }
}
