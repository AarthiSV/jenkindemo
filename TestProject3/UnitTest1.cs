//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using TestingEg;
using Moq;
namespace TestProject3
{
    [TestFixture]
    
    public class UnitTest1
    {
        Bank b;
        Empl e;
        Mock<IEmpl> m;
        [SetUp]
       public void first()
        {
           e = new Empl();
            m = new Mock<IEmpl>();
            b = new Bank();
        }
        
        public long bal = 50000;
        [Test]
        public void chkadd()
        {
            m.Setup(i => i.add(4, 5)).Returns(9);
            bool c = e.checkadd(4, 5);
            Assert.AreEqual(true, c);
        }
        [Test]
        public void testcredit()
        {
            long actual = b.credit(bal,20000);
            Assert.AreEqual(70000, actual);
        }
        [Test]
        public void testcredit2()
        {
            long act = b.credit(bal,30000);
            Assert.GreaterOrEqual(act, 70000);
        }
        [Test]
        public void testWithdraw()
        {
            
            long actual = b.withdraw(bal,10000);
            Assert.AreEqual(40000, actual);
        }
        [Test]
        public void testWithdraw2()
        {
           
            long act = b.withdraw(bal,10000);
            Assert.LessOrEqual(act, 40000);
        }
        [Test]
        public void testWithdrawfail()
        {
            Assert.Throws<InvalidOperationException>(()=>b.withdraw(bal,70000));
        }
        

    }
}
