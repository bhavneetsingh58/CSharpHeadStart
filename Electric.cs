using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessions
{
    class ELectric<T>
    {


        public ELectric(T t)
        {
            
        }

        public ELectric()
        {
        }

        T a;
        long AccNo;
        public void Bill(T b, long accNum)
        {
            a = b;
            long AccNo = accNum;
            Console.WriteLine("Mobile Number/email is: "+ a);
            Console.WriteLine("Accont Number is: "+accNum);
            Console.WriteLine("--------------");
        }

        public static void main()
        {
            ELectric<long> e1 = new ELectric<long>(8080008000);
            e1.Bill(8080008000, 12345);  

            ELectric<string> e2 = new ELectric<string>("Singh");
            e2.Bill("SIngh@singh.com", 12345);

        }

    }

}
