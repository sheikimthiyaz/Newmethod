using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newmethod
{
    class eg2
    {
        void distplayinguserdetails(string cn,string ci,string g,string mail)
        {
            Console.WriteLine("name:{0}||city:{2}||gender{2} email;{3}", cn, ci, g, mail);

        }
        static void Main()
        {
            string cname, city, gender, email;
            int[] mark = new int[3] { 89, 90, 91 };
            Console.WriteLine("enter name");
            cname = Console.ReadLine();
            Console.WriteLine("enter city");
            city= Console.ReadLine();
            Console.WriteLine("enter gender");
            gender= Console.ReadLine();
            Console.WriteLine("enter gender");
            email = Console.ReadLine();
            Eg2 eg2 = new Eg2();
            eg2.displayinguserdetails(cname, city, gender, email);
            Console.writeLine()




        }
}
