using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEg
{
    public class Empl:IEmpl
    {
        public int add(int x,int y)
        {
            return x + y;
        }
        public bool checkadd(int x,int y)
        {
           int a= add(x, y);
            if (a == (x + y))
                return true;
            else
                return false;
        }
        public string Message(string x)
        {
            return "hello " + x;
        }
    }
}
