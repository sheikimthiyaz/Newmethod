using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Newmethod
{
    class callbyreference
    {
        void byvalue(string p)
        {
            p = "00000000000";
            Console.WriteLine("value changed inside method :ph:{0}", p);
        }
        void byreference(ref string ph)
        {
            ph = "111111111";
            Console.Writeline("value changed inside,method:ph{0}", ph);
        }
        static void Main()
        {
            string phno = 8143694220;
            Methodwithparameters mobj = new Methodwithparameters();
            Console.WriteLine("before calling by value method:phno{0}", phno}
        mobj.byvalue(phno);
            Console.WriteLine("after calling by value method:phno{0}", phno }
    mobj.byvalue(phno);
    }
}
